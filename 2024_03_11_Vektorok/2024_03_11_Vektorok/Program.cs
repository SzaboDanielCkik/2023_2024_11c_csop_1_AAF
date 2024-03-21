using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_11_Vektorok
{
    class Program
    {

        static List<Vektor> vektorok = new List<Vektor>();
        static void Main(string[] args)
        {
            /* Két oszlop: Origóból kiinduló vektorok végpontjai. (x,y)
             * racionális számok
             * Feladat1: Adja meg a vektorok hosszának átlagát! (hossz = Gyök(x^2+y^2) )
             * Feladat2: Van-e olyan vektor, ami rajta van valamelyik tengelyen? (x=0 vagy y=0)*/

            Fajlbeolvasas();
            Feladat1();
            Feladat2();

            Console.ReadLine();
        }

        private static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            if(VaneTengelyenVektor())
                Console.WriteLine("Van egy vektor valamelyik tengelyen.");
            else
                Console.WriteLine("Nincs vektor egyik tengelyen sem.");
        }

        private static bool VaneTengelyenVektor()
        {
            int i = 0;
            while (i < vektorok.Count && !(vektorok[i].x == 0 || vektorok[i].y == 0))
                i++;
            return i < vektorok.Count;
        }

        private static void Feladat1()
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("A vektorok hosszának átlaga: {0}", 
                Math.Round(VektorokHosszAtlaga(),3));
        }

        

        private static double VektorokHosszAtlaga()
        {
            double osszeg = 0;
            for (int i = 0; i < vektorok.Count; i++)
            {
                osszeg += Math.Sqrt(Math.Pow(vektorok[i].x, 2) + Math.Pow(vektorok[i].y, 2));
            }
            return osszeg / vektorok.Count;
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("vektorok.csv");

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');
                Vektor sv = new Vektor();
                sv.x = Convert.ToDouble(st[0]);
                sv.y = Convert.ToDouble(st[1]);
                vektorok.Add(sv);
            }
            f.Close();     
        }
    }

    struct Vektor
    {
        public double x, y;
    }
}
