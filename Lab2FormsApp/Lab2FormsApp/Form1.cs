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

namespace Lab2FormsApp
{
    public partial class Form1 : Form
    {
        static void dinLaborator()
        {
            //citire din fisier
            if (File.Exists("C:\\Users\\ursu\\Desktop\\Univer\\Sem2\\MTP\\test.txt"))
            {
                StreamReader fin = new StreamReader(
                    "C:\\Users\\ursu\\Desktop\\Univer\\Sem2\\MTP\\test.txt");
                string linie = fin.ReadLine();
                textBox1.Text = linie;
                fin.Close();
            }
            else
                MessageBox.Show("Fisier Inexistent!");

            //scriere in Fisier
            string[] cuvinte = { "C", "C++", "Java", "Python" };

            StreamWriter fout = new StreamWriter(
                "C:\\Users\\ursu\\Desktop\\Univer\\Sem2\\MTP\\out.txt");
            foreach (var item in cuvinte)
                fout.WriteLine(item);

            fout.Close();
            MessageBox.Show("Fisier Scris");
        }

        static void exempluControlDinamic()
        {
            PictureBox pic = new PictureBox();

            //setarea proprietatilor
            pic.SetBounds(0, 0, 200, 200);
            pic.BackColor = Color.Black;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = Bitmap.FromFile("img");

            pic.Click += Pic_Click;
        }

        private static void Pic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
