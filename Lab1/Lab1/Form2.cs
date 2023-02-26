using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = System.DateTime.Today.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textName.Text;
            string prenume = textSurename.Text;
            string varsta = textAge.Text;

            //verifica campuri goale
            if ((textAge.Text == "") || (textName.Text == "") || (textSurename.Text == ""))
                MessageBox.Show("Completati toate campurile !");
            else
            {
                //alta metoda de verificare camp - sa contina doar litere
                if (!Regex.Match(textName.Text, "^[A-Z][a-zA-Z]*$").Success)
                {
                    // numele este incorect
                    MessageBox.Show("Nume invalid", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textAge.Focus();
                    return;
                }
                string judet = listBoxJudet.SelectedItem.ToString();

                string gen;
                if (radioButton1.Checked == true)
                    gen = radioButton1.Text;
                else
                    gen = radioButton2.Text;
                //cream lista de limbaje de programare
                string lp = "";
                if (checkBox1.Checked)
                    lp = lp + " " + checkBox1.Text;
                if (checkBox2.Checked)
                    lp = lp + " " + checkBox2.Text;
                if (checkBox3.Checked)
                    lp = lp + " " + checkBox3.Text;
                if (checkBox4.Checked)
                    lp = lp + " " + checkBox4.Text;
                if (checkBox4.Checked)
                    lp = lp + " " + checkBox4.Text;
                string linie = nume + " " + prenume + " " + judet + " " + gen + " " + lp;
                listBox2.Items.Add(linie);
            }
        }
    }
}
