using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XANDO
{
    internal class WinningCombos
    {
        Label label;

        public WinningCombos(Label label) { this.label = label; }

        public void win(int[,] arr, int x, int y, String winner)
        {
            int n = 3;

            for (int i = 0; i < n; i++)
                if (arr[x, i] != 1)
                    break;
                else if(i == n - 1)
                {
                    label.Text = winner + " Won!";
                }

            for (int i = 0; i < n; i++)
                if (arr[i, y] != 1)
                    break;
                else if (i == n - 1)
                {
                    label.Text = winner + " Won!";
                }

            if (x == y)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i, i] != 1)
                        break;
                    if (i == n - 1)
                    {
                        label.Text = winner + " Won!";
                    }
                }
            }

            //check anti diag
            for (int i = 0; i < n; i++)
            {
                if (arr[i, (n - 1) - i] != 1)
                    break;
                if (i == n - 1)
                {
                    label.Text = winner + " Won!";
                }
            }
        }   
    }
}
