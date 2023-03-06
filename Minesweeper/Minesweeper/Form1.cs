using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Minesweeper.CollorPalete;
using static Minesweeper.ModdedButton;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        CollorPalete Col = new CollorPalete();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Col.c2;
            this.ForeColor = Col.c6;

            panel1.BackColor = Col.c3;
            panel2.BackColor = Col.c6;

            panel3.BackColor = Col.c3;
            panel4.BackColor = Col.c6;

            comboBox_Size.BackColor = Col.c1;
            comboBox_Size.DropDownStyle = ComboBoxStyle.DropDownList;

            but_close.FlatStyle = FlatStyle.Flat; //copie asta
            but_close.FlatAppearance.BorderSize = 0;
            but_close.BackColor = Col.c1;
            but_start.FlatStyle = FlatStyle.Flat;
            but_start.FlatAppearance.BorderSize = 0;
            but_start.BackColor = Col.c1;

            //FlowLayoutPanel gameFlowLayout = new FlowLayoutPanel();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            if (comboBox_Size.Text == "")
                MessageBox.Show("Mai intai selecteaza o dimensiune!");
            else
            {
                Form2 form2 = new Form2(int.Parse(comboBox_Size.Text));
                form2.Show();
                //new form
            }
        }
    }
}
