using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_01_12_Fajlbeolvasas
{
    class Program
    {
        static List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();

        static void Main(string[] args)
        {
            //Fajlbeolvasas1();
            Fajlbeolvasas2();

            /*for (int i = 0; i < gyumolcsok.Count; i++)
                Console.WriteLine(gyumolcsok[i]);*/

            Console.ReadLine();
        }

        static void Fajlbeolvasas2()
        {
            // a szöveges állományt megnyitjuk olvasásra + belekerülnek az adatok egy puffer-be
            StreamReader f = new StreamReader("gyumolcsok.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                string[] st = sor.Split(' ');
                Gyumolcs sv = new Gyumolcs();
                sv.gyumolcsnev = st[0];
                sv.egysegar = Convert.ToInt32(st[2]);
                sv.mennyiseg = Convert.ToInt32(st[1]);
                gyumolcsok.Add(sv);
            }
            f.Close();
        }

        static void Fajlbeolvasas1()
        {
            string[] adatok = File.ReadAllLines("gyumolcsok.txt");
            for (int i = 0; i < adatok.Length; i++)
                Console.WriteLine(adatok[i] + " ");
        }
    }

    struct Gyumolcs {
        public string gyumolcsnev;
        public int mennyiseg, egysegar;

        public override string ToString()
        {
            return string.Format($"{gyumolcsnev} {mennyiseg} kg {egysegar} Ft");
        }
    }
}
