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

    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
            addItemsToComboBox(comboBox1);
        }

        void addItemsToComboBox(ComboBox cb)
        {
            StreamReader fin = new StreamReader("in.txt");
            StreamReader fin_parole = new StreamReader("parole.txt");

            while (!fin.EndOfStream && !fin_parole.EndOfStream)
            {
                string n = fin.ReadLine();
                cb.Items.Add(n);
                string p = fin_parole.ReadLine();
                users.Add(new User(n, p));
            }
            fin.Close();
            fin_parole.Close();
        }

        private void button1_Click(object sender, EventArgs e) // autentificare
        {
            string user = comboBox1.SelectedText;
            string password = textBox1.Text;

            foreach(var item in  users)
            {
                if(item.name == user)
                    if(item.password == password)
                    {
                        Form3 form = new Form3();
                        form.ShowDialog();
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }

    public class User
    {
        public string name;
        public string password;
        public User(string n, string p)
        {
            name = n;
            password = p;
        }
    }
}
