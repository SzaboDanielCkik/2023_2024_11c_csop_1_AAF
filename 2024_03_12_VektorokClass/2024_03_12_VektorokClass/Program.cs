using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_12_VektorokClass
{
    class Program
    {
        //static List<Vektor> vektorok = new List<Vektor>();
        static Vektorok v = new Vektorok("vektorok.csv");
        static void Main(string[] args)
        {
            //Fajlbeolvasas();
            //Feladat1();

             

            Console.WriteLine(v.VektorHosszAtlag());

            Console.ReadLine();
        }

        //private static void Feladat1()
        //{
        //    Console.WriteLine("1. feladat");
        //    Console.WriteLine("A vektorok hosszának átlaga: {0}",
        //        VektorHosszAtlag());
        //}

        //private static double VektorHosszAtlag()
        //{
        //    double osszeg = 0;
        //    for (int i = 0; i < vektorok.Count; i++)
        //    {
        //        osszeg += vektorok[i].Hossz();
        //    }
        //    return osszeg / vektorok.Count;
        //}

        //private static void Fajlbeolvasas()
        //{
        //    StreamReader f = new StreamReader("vektorok.csv");
        //    while (!f.EndOfStream)
        //        vektorok.Add(new Vektor(f.ReadLine()));
        //    f.Close();
        //}
    }

    class Vektorok
    {
        private List<Vektor> vektorok;
        public Vektorok(string beolvasandoSzovegesFajlUtvonala)
        {
            vektorok = Fajlbeolvasas(beolvasandoSzovegesFajlUtvonala);
        }

        private List<Vektor> Fajlbeolvasas(string path)
        {
            List<Vektor> sLista = new List<Vektor>();
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
                sLista.Add(new Vektor(f.ReadLine()));
            f.Close();
            return sLista;
        }

        public double VektorHosszAtlag()
        {
            double osszeg = 0;
            for (int i = 0; i < vektorok.Count; i++)
            {
                osszeg += vektorok[i].Hossz();
            }
            return osszeg / vektorok.Count;
        }


    }

    class Vektor
    {
        public double x = 0, y = 0;

        public Vektor(string sor)
        {
            string[] st = sor.Split(';');
            x = Convert.ToDouble(st[0]);
            y = Convert.ToDouble(st[1]);
        }

        public double Hossz()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public bool TengelyenVane()
        {
            return x == 0 || y == 0;
        }

    }



    class OsztalyNev
    {
        //Mezők, adattag, jellemző, tulajdonság
        public string a;

        //Konstruktor
        public OsztalyNev(string b) {
            a = b + "1";
        }
        //Metódusok
        public void Metodus(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
            }
        }
    }
}
