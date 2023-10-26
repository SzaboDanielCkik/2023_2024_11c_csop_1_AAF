using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19_Gyakorlas
{
    class Program
    {
        static int[] t = new int[50];
        static void Main(string[] args)
        {
            // Töltsön fel egy 50 elemű tömböt kétjegyű 5-tel osztható számokkal.
            // 1. feladat: Adja meg a számok átlagát!
            // 2. feladat: Adja meg a számok mediánját!
            // 3. feladat: Adja meg a számok móduszát!
            // 4. feladat: Írassa ki hány db különböző szám van? Írassa ki mindet!

            Tombfeltoltes();
            Feladat1();
            Feladat2();
            /*Feladat3();
            Feladat4();*/
            Console.ReadLine();
        }

        static void Feladat2()
        {
            Rendezes();
        }

        static void Rendezes()
        { 
            
        }

        static void Feladat1()
        {
            Console.WriteLine("A számok átlaga: " + Math.Round(Atlag(), 2));
        }

        static double Atlag()
        {
            double osszeg = 0;
            for (int i = 0; i < t.Length; i++)
                osszeg += t[i];
            return osszeg / t.Length;
        }

        static void Tombfeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(2,20)*5;
            }
        }
    }
}
