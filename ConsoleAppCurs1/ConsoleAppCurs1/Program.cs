using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppCurs1
{
    internal class Program
    {
        public static void afisari()
        {
            string str = "Dumitru";
            int nr = 1;

            //Console.WriteLine("Ma numesc Dumitru!");

            Console.WriteLine("{1} este {0}", str, nr);

            Console.WriteLine("{0,10}", "tata");
            Console.WriteLine("{0,10}", "mama-tata");
            Console.WriteLine("{0,10}", "ta");
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end");

            Console.WriteLine("{0:C2}", 123.456); // currency
            Console.WriteLine("{0:D6}", -1234); // aproxiamtion
            Console.WriteLine("{0:E2}", 123); // exponent
            Console.WriteLine("{0:F2}", -123.456); // down aproximation
            Console.WriteLine("{0:N2}", 1234567.8); // aproximation after comma
            Console.WriteLine("{0:P}", 0.456); // percentage
            Console.WriteLine("{0:X}", 254); // hexa

            //formate non standard - definite de utilizator
            Console.WriteLine("{0:0.00}", 123.1234);
            Console.WriteLine("{0:#.##}", 23.2345);
            Console.WriteLine("{0:####}", 1234.12);
            Console.WriteLine("{0:(0#) ### ## ##}", 12345678);
            Console.WriteLine("{0:%##}", 0.236);

            Console.WriteLine();

            //formate date
            //DateTime d = new DateTime(2023, 2, 28, 10, 55, 00);
            DateTime d = DateTime.Now;
            //standart
            Console.WriteLine("{0:D}", d);
            Console.WriteLine("{0:T}", d);
            Console.WriteLine("{0:d}", d);
            //custom
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
            Console.WriteLine("{0:d.MM.yy}", d);

            Console.WriteLine();

            //formate String pentru argumente de tip enumerare
            Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
            Console.WriteLine("{0:D}", DayOfWeek.Friday);
            Console.WriteLine("{0:X}", DayOfWeek.Thursday);

            Console.WriteLine();

            //Localizarea regiunii p/u afisarea datei sau zecimaleor
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("en-US: {0:d}", d);
            Console.WriteLine("{0:N}", 1234.56);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ro-RO");
            Console.WriteLine("ro-RO: {0:d}", d);
            Console.WriteLine("{0:N}", 1234.56);
        }

        public static void introducere()
        {
            // Console.ReadLine() -> citeste pana la ENTER
            //Console.Write("Nume: ");
            //string nume = Console.ReadLine();
            //Console.Write("Prenume: ");
            //string prenume = Console.ReadLine();

            //Console.WriteLine("Salut, {0} {1}", nume, prenume);

            Console.Write("Introdu a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introdu b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }

        public static void parsareConditionala() 
        {
            Console.Write("Introdu un numar : ");
            string str = Console.ReadLine();

            // The out keyword causes arguments to be passed by reference
            bool parseSucces = Int32.TryParse(str, out int intValue);

            Console.WriteLine(parseSucces ? 
                "Patratul numarului {0} este : " + intValue * intValue : "Numar invalid",intValue);
        }

        public static void consoleReadKey()
        {
            Console.Write("Introdu un key sau o combinatie : ");
            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Character entered = " + key.KeyChar);
            Console.WriteLine("Special key = " + key.Modifiers);
        }

        static void Main(string[] args)
        {

            // Ctrl + K -> Ctrl + C -> comment section
            // Ctrl + k -> Ctrl + U -> uncomment section
            // Ctrl + D -> duplicate current line

            //afisari();
            //afisari();
            //introducere();
            //parsareConditionala();
            consoleReadKey();

            Console.ReadKey();
        }
    }
}
