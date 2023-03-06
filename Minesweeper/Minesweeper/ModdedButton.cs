using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class ModdedButton : Button
    {
        public int value;
        public static bool firstClick = false;
        public int x, y;
        public bool isFlagged = false;
        public bool isLeftClicked = false;

        public void ShowValue()
        {
            this.Text = value.ToString();
        }
    }
}
