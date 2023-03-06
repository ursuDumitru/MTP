using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCurs2
{
    class Person
    {
        private string nume;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
    }


    internal class Program
    {
        static void variabileNeutilizate()
        {
            string s;
            int x = Console.Read();
            if (x >= 48 && x <= 57)
                s = "#";
            else //fara asta nu se compileaza !
                s = "*";

            Console.WriteLine(s);
        }

        static void varType()
        {
            var nume = "Dumitru";
            var numar = 5;
            var isGood = true;
            Type tipNume = nume.GetType();
            Type tipNumar = numar.GetType();
            Type tipIsGood = isGood.GetType();
            Console.WriteLine("{0} are tipul : " + tipNume.ToString(), nume);
            Console.WriteLine("{0} are tipul : " + tipNumar.ToString(), numar);
            Console.WriteLine("{0} are tipul : " + tipIsGood.ToString(), isGood);
        }

        static void jocCuSetGet()
        {
            Person pers = new Person();

            pers.Nume = "Dumitru";
            Console.WriteLine(pers.Nume);
        }

        static void directoryInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\ursu\Desktop");
            //vector de obiecte DirectoryInfo
            FileSystemInfo[] subDirs = // tipul vectorului depinde de ce vrem sa gasim
                di.GetFileSystemInfos();  // in di (fisiere, directoare, ambele)
            foreach(var dir in subDirs)
            {
                Console.WriteLine(dir.Name); // FullName = path. Poate fi si name
            }

            Console.WriteLine("in {0} sunt {1} directorii",
                di.Name, di.EnumerateDirectories().Count());
            Console.WriteLine("in {0} sunt {1} fisiere",
                di.Name, di.EnumerateFiles().Count());
        }

        //static void 

        static void Main(string[] args)
        {
            //var i = 8;
            //variabileNeutilizate();
            //varType();
            //jocCuSetGet();
            //directoryInfo();

            Console.ReadKey();
        }
    }
}
