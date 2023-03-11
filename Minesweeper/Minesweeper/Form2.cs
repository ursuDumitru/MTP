using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.CollorPalete;
using static Minesweeper.ModdedButton;
using static Minesweeper.Game;
using System.IO.Ports;
using System.Diagnostics;
using System.Xml;

namespace Minesweeper
{
    public partial class Form2 : Form
    {
        //  ************** Global variables for easy use *******************   //

        readonly CollorPalete Col = new CollorPalete();
        Game game;
        int gameSize;
        FlowLayoutPanel game_area = new FlowLayoutPanel();
        int buttonsWithoutBombs;
        int availableFlags;
        Timer timer = new Timer();
        Stopwatch stopwatch = new Stopwatch();
        DateTime startTime;
        String finishTime;
        String playerName;
        XmlDocument players_xml = new XmlDocument();
        bool won;

        //  ***********************************************************   //

        public Form2(int selected_size, string player_name)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            //  **************** Setting up the Form2 *********************   //
            playerName = player_name;
            label_player.Text = player_name;
            timer.Tick += new EventHandler(timerEvent);
            timer.Interval = 1000;
            buttonsWithoutBombs = selected_size * (selected_size - 1);// without bombs
            availableFlags = selected_size;
            this.gameSize = selected_size;
            this.BackColor = Col.c2;
            this.ForeColor = Col.c5;
            panel1.BackColor = Col.c3;
            panel2.BackColor = Col.c6;
            panel3.BackColor = Col.c3;
            panel4.BackColor = Col.c6;
            but_close.FlatStyle = FlatStyle.Flat;
            but_close.FlatAppearance.BorderSize = 0;
            but_close.BackColor = Col.c1;
            but_reset.FlatStyle = FlatStyle.Flat; //copie asta
            but_reset.FlatAppearance.BorderSize = 0;
            but_reset.BackColor = Col.c1;
            label_remaining_bombs.Text = selected_size.ToString();

            //  ***********************************************************   //


            //  **************** Creating the game area *******************   //

            int half = this.Size.Width / 2;
            game_area.Size = new Size(selected_size * 32, selected_size * 32);
            game_area.Location = new Point(half - game_area.Size.Width/2, 100);
            game_area.BackColor = Col.c3;

            for(int i = 0; i < selected_size; i++)
                for(int j = 0; j < selected_size; j++)
                {
                    ModdedButton b = new ModdedButton();
                    b.x = i; b.y = j;
                    b.Name = "but_square" + (i + j);
                    b.Size = new Size(30, 30);
                    b.BackColor = Col.c1;
                    b.Margin = new Padding(1, 1, 1, 1);
                    b.MouseDown += Square_MouseClick;
                    game_area.Controls.Add(b);
                }

            this.Controls.Add(game_area);

            //  ***********************************************************   //
        }

        //  **************** Event handlers for buttons *******************   //
        void Square_MouseClick(object sender, MouseEventArgs e)
        {
            ModdedButton b = sender as ModdedButton;

            if (!ModdedButton.firstClick)
            {
                startTime = DateTime.Now;
                timer.Start();
                game = new Game(gameSize, gameSize, b.x, b.y);
                ModdedButton.firstClick = true;
                foreach(ModdedButton k in game_area.Controls)
                    k.value = game.GameArray[k.x][k.y];
            }
            if (!b.isLeftClicked)
                if (e.Button == MouseButtons.Left)
                {
                    b.isLeftClicked = true;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.BackColor = Col.c3;
                    if (b.value == 9)
                    {
                        b.BackgroundImage = null;
                        b.BackgroundImage = Image.FromFile("bombCropped28.png");
                        timer.Stop();
                        won = false;
                        addToXmlInfo();
                        MessageBox.Show("Game Over");
                        resetFunction();
                    }
                    else if (b.value < 9 && b.value != 0)
                    {
                        b.BackgroundImage = null;
                        b.ShowValue();
                        buttonsWithoutBombs--;
                    }
                    else if (b.value == 0)
                        clickedZero(b);
                    
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if(!b.isFlagged && availableFlags > 0)
                    {
                        b.isFlagged = true;
                        availableFlags--;
                        label_remaining_bombs.Text = availableFlags.ToString();
                        b.BackgroundImage = Image.FromFile("redFlag2Cropped28.png");
                    } else if (b.isFlagged && availableFlags < gameSize)
                    {
                        b.isFlagged = false;
                        availableFlags++;
                        label_remaining_bombs.Text = availableFlags.ToString();
                        b.BackgroundImage = null;
                    }
                }
            if(buttonsWithoutBombs == 0)
            {
                timer.Stop();
                won = true;
                addToXmlInfo();
                MessageBox.Show("You Won !");
                resetFunction();
            }
        }

        //  ************* Event handlers for zero buttons *****************   //
        void clickedZero(ModdedButton b)
        {
            b.BackgroundImage = null;
            b.isLeftClicked = true;
            buttonsWithoutBombs--;
            b.FlatStyle = FlatStyle.Flat; // Some Error Here
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Col.c3;
            foreach (ModdedButton k in game_area.Controls)
            {
                int[] dX = new int[] { -1, 0, 1 };
                int[] dY = new int[] { -1, 0, 1 };

                for(int i = 0; i < dX.Length; i++)
                    for(int j = 0; j < dY.Length; j++)
                        if(k.value == 0)
                        {
                            if (!k.isLeftClicked &&
                                k.x == b.x + dX[i] &&
                                k.y == b.y + dY[j])
                                clickedZero(k);
                        } else if(k.value != 0 && k.value < 9)
                            if(!k.isLeftClicked &&
                                k.x == b.x + dX[i] &&
                                k.y == b.y + dY[j])
                            {
                                k.isLeftClicked = true;
                                buttonsWithoutBombs--;
                                k.FlatStyle = FlatStyle.Flat; // Some Error Here
                                k.FlatAppearance.BorderSize = 0;
                                k.BackColor = Col.c3;
                                k.ShowValue();
                            }
            }
        }

        //  ********************** Reset Function *************************   //
        void resetFunction()
        {
            ModdedButton.firstClick = false;
            Form2 form2 = new Form2(gameSize, playerName);
            form2.Show();
            this.Close();
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModdedButton.firstClick = false;
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            resetFunction();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerEvent(object sender, EventArgs e)
        {
            finishTime = (DateTime.Now - startTime).ToString(@"mm\:ss");
            label_time.Text = finishTime;
        }

        private void addToXmlInfo()
        {
            players_xml.Load("players.xml");
            XmlNode players = players_xml.SelectSingleNode("players");
            XmlNode player = players_xml.CreateNode(XmlNodeType.Element, "player", "");

            XmlAttribute w = players_xml.CreateAttribute("did_won");
            w.Value = won.ToString();
            XmlAttribute s = players_xml.CreateAttribute("size");
            s.Value = gameSize.ToString();
            player.Attributes.Append(w);
            player.Attributes.Append(s);

            XmlNode player_name = players_xml.CreateNode(XmlNodeType.Element, "name", "");
            player_name.InnerText = playerName;
            XmlNode player_time = players_xml.CreateNode(XmlNodeType.Element, "time", "");
            player_time.InnerText = finishTime;
            player.AppendChild(player_name);
            player.AppendChild(player_time);

            players.AppendChild(player);
            players_xml.Save("players.xml");
        }
    }
}
