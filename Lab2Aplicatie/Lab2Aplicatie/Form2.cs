using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Aplicatie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Salveaza
        {
            string nume = textBox1.Text;
            string parola = textBox2.Text;

            if (nume != "" && parola != "")
            {
                timer1.Start();
                StreamWriter fout = File.AppendText("in.txt");
                StreamWriter fout_p = new StreamWriter("parole.txt");
                fout.WriteLine(nume);
                fout_p.WriteLine(parola);
                fout.Close();
                fout_p.Close();
            }
            else
                MessageBox.Show("Introdu date !");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            progressBar1.Value -= 1;
            progressBar1.Value += 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Inregistrare Reusita !");
                Application.Restart();
            }
        }
    }
}
