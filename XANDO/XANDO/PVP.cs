using System;
using System.Drawing;
using System.Windows.Forms;
using static XANDO.WinningCombos;

namespace XANDO
{
    public partial class PVP : Form
    {
        Color c1 = Color.FromArgb(7, 190, 184);
        Color c2 = Color.FromArgb(61, 204, 199);
        Color c3 = Color.FromArgb(104, 216, 214);
        Color c4 = Color.FromArgb(156, 234, 239);
        Color c5 = Color.FromArgb(196, 255, 249);

        bool turn = true; //1 = X, 0 = O
        String xT = "X's Turn";
        String oT = "O's Turn";

        int[,] arrX = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int[,] arrY = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };


        void initiate()
        {
            this.BackColor = c5;
            this.ForeColor = c1;
            flowLayoutPanel1.BackColor = c3;
            button1.FlatAppearance.BorderSize = 0;
            reset_board();
            label_turn.Text = xT;
        }
        void reset_board()
        {
            foreach (Button c in flowLayoutPanel1.Controls)
            {
                c.Text = "";
                c.BackColor = c4;
                c.FlatStyle = FlatStyle.Flat;
                c.FlatAppearance.BorderSize = 0;
            }

            arrX = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            arrY = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            turn = true;
            label_turn.Text = xT;
        }
        void but_press(Button bt, int x, int y)
        {
            if(label_turn.Text != "X Won!" && label_turn.Text != "O Won!")
            {
                WinningCombos wc = new WinningCombos(label_turn);

                if (bt.Text != "")
                    return;

                if (turn)
                {
                    bt.Text = "X";
                    label_turn.Text = oT;
                    arrX[x, y] = 1;
                    turn = false;
                }
                else
                {
                    bt.Text = "O";
                    label_turn.Text = xT;
                    arrY[x, y] = 1;
                    turn = true;
                }
                wc.win(arrX, x, y, "X");
                wc.win(arrY, x, y, "O");
            }
        }

        public PVP()
        {
            InitializeComponent();
            initiate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 1, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 2, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 0, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 2, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 0, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 1, 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            but_press((Button)sender, 2, 2);
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            reset_board();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
