using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XANDO
{
    public partial class Form1 : Form
    {
        Color c1 = Color.FromArgb(7, 190, 184);
        Color c2 = Color.FromArgb(61, 204, 199);
        Color c3 = Color.FromArgb(104, 216, 214);
        Color c4 = Color.FromArgb(156, 234, 239);
        Color c5 = Color.FromArgb(196, 255, 249);

        void button_style(Button bt)
        {
            bt.BackColor = c4;
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
            bt.ForeColor = c2;
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = c5;
            button_style(but_pvc);
            button_style(but_pvp);
            button_style(but_close);
            
        }

        private void but_pvp_Click(object sender, EventArgs e)
        {
            PVP pvp_form = new PVP();
            pvp_form.Show();
            //this.Hide();
        }

        private void but_pvc_Click(object sender, EventArgs e)
        {
            PVC pVC_form = new PVC();
            pVC_form.Show();
            //this.Hide();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
