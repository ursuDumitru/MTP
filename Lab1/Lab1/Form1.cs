using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((name.Text == "Dumitru") && (pass.Text == "admin"))
            {
                Form f = new Form2();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Utilizator/Parola Incorecta");
        }
    }
}
