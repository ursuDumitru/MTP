using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static Minesweeper.CollorPalete;

namespace Minesweeper
{
    public partial class Scoreboard : Form
    {
        readonly CollorPalete col = new CollorPalete();
        public Scoreboard()
        {
            InitializeComponent();

            this.BackColor = col.c2;
            this.ForeColor = col.c6;

            panel1.BackColor = col.c3;
            panel2.BackColor = col.c6;
            panel3.BackColor = col.c3;
            panel4.BackColor = col.c6;

            but_close.FlatStyle = FlatStyle.Flat; //copie asta
            but_close.FlatAppearance.BorderSize = 0;
            but_close.BackColor = col.c1;

            XmlDocument players_xml = new XmlDocument();
            players_xml.Load("players.xml");
            XmlNode players = players_xml.SelectSingleNode("players");

            foreach(XmlNode xn in  players)
            {
                string name, did_won, time, size;
                size = xn.Attributes["size"].Value;
                if (xn.Attributes["did_won"].Value == "True")
                    did_won = "won";
                else
                    did_won = "lost";
                name = xn.FirstChild.InnerText;
                time = xn.LastChild.InnerText;
                string line = name + " " + did_won + " " + time + " " + size;

                list_scoreboard.Items.Add(line);
            }
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
