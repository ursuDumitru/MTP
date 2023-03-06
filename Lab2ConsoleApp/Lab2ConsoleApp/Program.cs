using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //citire din fisier o singura linie
            if (File.Exists("C:\\Users\\ursu\\Desktop\\Univer\\Sem2\\MTP"))
            {
                StreamReader fin = new StreamReader("C:\\Users\\ursu\\Desktop\\Univer\\Sem2\\MTP");
                string linie = fin.ReadLine();

            }
        }
    }
}
