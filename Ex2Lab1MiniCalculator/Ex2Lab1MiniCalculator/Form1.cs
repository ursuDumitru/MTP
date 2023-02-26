using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Ex2Lab1MiniCalculator
{
    public partial class Form1 : Form
    {
        int check = 0, check2 = 0,  caz = -1, check_one_op = 0; //caz {0 -> + ; 1 -> - ; 2 -> * ; 3 -> /
        double nr1, nr2;
        public Form1()
        {
            InitializeComponent();
        }

        public string opToString(int op)
        {
            switch (op)
            {
                case 0:
                    return "+";
                case 1:
                    return "-";
                case 2:
                    return "*";
                case 3:
                    return "/";
            }

            return "error";
        }

        public void wait(int milliseconds) //idea ar fi sa afisez putin operatia in textBox
        {                                  // dar intervin ceva problema asa ca nu o folosesc
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public void do_calc(int c)
        {
            if (textBox1.Text != "" || caz != -1) // Nu sunt sigur de ||
            {
                nr2 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                switch (caz)
                {
                    case 0:
                        nr1 += nr2;
                        break;
                    case 1:
                        nr1 -= nr2;
                        break;
                    case 2:
                        nr1 *= nr2;
                        break;
                    case 3:
                        if (nr2 == 0)
                        {
                            MessageBox.Show("Impartire la 0 nu exista !");
                            caz = -1;
                            return;
                        }
                        nr1 /= nr2;
                        break;
                    default:
                        MessageBox.Show("Introdu operatia!");
                        return;
                }
                if (c == 1)
                    textBox1.Text = nr1.ToString();
                
            }
            else
                MessageBox.Show("Introdu numar/operatie !");
        }

        public void operation(int op)
        {
            if (check_one_op == 1)
                return;
            if (textBox1.Text != "" )
            {
                if (check2 == 0)
                {
                    nr1 = double.Parse(textBox1.Text);
                    //textBox1.Text = opToString(op);
                    //wait(1000); // asteptam putin ca sa vedem operatia in textBox
                    textBox1.Text = "";
                    check = 1;
                    check2 = 1;
                    caz = op;
                }
                else
                {
                    do_calc(0);
                    //textBox1.Text = opToString(caz);
                    //wait(1000); // asteptam putin ca sa vedem operatia in textBox
                    textBox1.Text = "";
                    caz = op;
                }
                check_one_op = 1;
            }
            else
                MessageBox.Show("Introdu numar/operatie !");
        }

        public void add_number(string nr)
        {
            check = 0;
            check_one_op = 0;
            textBox1.Text += nr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_number("1");
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            add_number("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_number("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add_number("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_number("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_number("6");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            add_number("7");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            add_number("8");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add_number("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            add_number("0");
        }

        private void button9_Click(object sender, EventArgs e) // +
        {
            operation(0);
        }

        private void button11_Click(object sender, EventArgs e) // *
        {
            operation(2);
        }

        private void button15_Click(object sender, EventArgs e) // -
        {
            operation(1);
        }


        private void button7_Click(object sender, EventArgs e) // /
        {
            operation(3);
        }


        private void button18_Click(object sender, EventArgs e) // =
        {
            do_calc(1);
            check2 = 0;
            check_one_op = 0;
        }

        private void button17_Click(object sender, EventArgs e) // -/+
        {
            if (check == 0 && textBox1.Text != "" && double.Parse(textBox1.Text) != 0)
            {
                textBox1.Text = (-1 * double.Parse(textBox1.Text)).ToString();
            }
            else
                MessageBox.Show("Introdu un numar!");
        }

        private void button12_Click(object sender, EventArgs e) // .
        {
            if (!textBox1.Text.Contains("."))
                add_number(".");
        }

        private void button2_Click(object sender, EventArgs e) // sqrt
        {
            if (textBox1.Text != "" && double.Parse(textBox1.Text) >= 0)
                textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
            else
                MessageBox.Show("Nu pot scoate radical din acest nr !");
        }

        private void button19_Click(object sender, EventArgs e) // exit
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e) //clear
        {
            nr1 = 0;
            nr2 = 0;
            textBox1.Text = "";
            check = 1;
            check2 = 0;
            caz = -1;
        }
    }
}
