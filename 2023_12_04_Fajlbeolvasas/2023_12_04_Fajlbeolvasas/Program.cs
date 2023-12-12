using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2023_12_04_Fajlbeolvasas
{
    struct Gyumolcs
    {
        public string nev;
        public int ertek;
    }

    class Program
    {
        static List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();
        static List<string> sorok = new List<string>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();

            Console.ReadLine();
        }

        static void Fajlbeolvasas()
        {
            sorok = File.ReadAllLines("adatok.txt").ToList();
            for (int i = 0; i < sorok.Count; i++)
            {
                string[] st = sorok[i].Split(' ');
                Console.WriteLine("{0} - {1}", st[0], st[1]);

                Gyumolcs sv = new Gyumolcs(); //példányosítás
                sv.nev = st[0];
                sv.ertek = Convert.ToInt32(st[1]);
                gyumolcsok.Add(sv);
            }
        }
    }
}
