using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    internal class Jackie
    {
        static List<Adatok> adat = new List<Adatok>();
        static void Main(string[] args)
        {

            Console.WriteLine("\nA program kezdődik...");

            //*2. feladat
            Beolvasas("jackie.txt", Encoding.Default);

            //*3. feladat
            feladat03();

            //*4. feladat
            feladat04();

            //*5.feladat
            feladat05();

            //*6.feladat
            feladat06();

            Console.WriteLine("\nA program vége!");
            Console.ReadKey();
        }

        private static void feladat06()
        {
            try
            {

                List<Adatok> rendezett = adat.OrderByDescending(x => x.Ev).ToList();
                StreamWriter Ir = new StreamWriter("jackie.html", false, Encoding.UTF8);
                Ir.WriteLine("<!doctype html>");
                Ir.WriteLine("<html>");
                Ir.WriteLine("<head></head>");
                Ir.WriteLine("<style> td{ border:1px solid black;}</style>");
                Ir.WriteLine("<body>");
                Ir.WriteLine("<h1>Jackie Stewart</h1>");
                Ir.WriteLine("<table>");
                for (int i = 0; i < rendezett.Count; i++)
                {

                    Ir.WriteLine($"<tr><td>{rendezett[i].Ev}</td><td>{rendezett[i].Verseny}</td><td>{rendezett[i].Nyert}</td></tr>");

                }
                Ir.WriteLine("</table>");
                Ir.WriteLine("</body>");
                Ir.WriteLine("</html>");
                Ir.Close();
                Console.WriteLine("6. feladat: jackie.html");

            }
            catch(Exception)
            {

                Console.WriteLine("Nem sikerült a jackie.html létrehozása!");

            }

        }

        private static void feladat05()
        {

            Console.WriteLine($"5. feladat: ");
            Console.WriteLine($"\t70-es évek: {adat.Where(x => x.Ev >= 1970 && x.Ev < 1980).Sum(y => y.Nyert)} megnyert verseny");
            Console.WriteLine($"\t60-es évek: {adat.Where(x => x.Ev >= 1960 && x.Ev < 1970).Sum(y => y.Nyert)} megnyert verseny");

        }

        private static void feladat04()
        {

            Console.WriteLine($"4. feladat: {adat.OrderBy(x => x.Verseny).Last().Ev}");

        }

        private static void feladat03()
        {

            Console.WriteLine($"3. feladat: {adat.Count}");

        }

        private static void Beolvasas(string adatFile, Encoding @default)
        {

            if (!File.Exists(adatFile))
            {

                Console.WriteLine("A forrás adatok hiányoznak!");
                Console.ReadLine();

                Environment.Exit(0);
            }

            using (StreamReader sr = new StreamReader(adatFile))
            {
                string fejlec = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    adat.Add(new Adatok(sr.ReadLine()));
                }

            }

        }
    }
}
