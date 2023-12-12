using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_04_ListabanALista
{
    class Program
    {

        static List<List<int>> szamok = new List<List<int>>();

        static void Main(string[] args)
        {
            //Készítsen egy olyan programot, ami feltölt egy 13 elemű listát változó elemszámú listával. [1,10] darab érték lehet egy belső listában.
            //A lista elemeinek értéke [10,20] közöttiek

            /*List<int> sl = new List<int>();
            sl.Add(12);
            sl.Add(13);
            sl.Add(16);
            szamok.Add(sl);*/

            ListaFeltoltes();
            ListaKiiratas();

            //Feladat1: FV : Hány darab számunk van a teljes szamok listában?
            //Feladat2: Elj: Rendezze a belső lista elemeinek értékét növekvő!
            //Feladat3: Elj: Adott az összes elem darabszáma, pakolja át az elemeket a legszűkebb hozzá tartozó mátrixba.
            /* 7 8
             * 8 9 3 2
             * 2
             * 7 elemet = 2x4
             * 9 elemet = 3x3 
             * 11 elemet = 3x4
             * 47 elemet = 6x8 
             * 80 elemet = 8x10 (n+m minimális)*/

            Console.ReadLine();
        }

        static void ListaKiiratas()
        {
            for (int i = 0; i < szamok.Count; i++)
            {
                for (int j = 0; j < szamok[i].Count; j++)
                    Console.Write(szamok[i][j]+" ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ListaFeltoltes()
        {
            Random r = new Random();
            //13 db listát fogunk létrehozni
            for (int i = 0; i < 13; i++)
            {
                List<int> sl = new List<int>();
                //Segéd lista feltöltése véletlen elemszámmal
                int elemszam = r.Next(1, 11);
                for (int j = 0; j < elemszam; j++)
                {
                    sl.Add(r.Next(10, 21));
                }
                //segédlista hozzáadása a fő listához
                szamok.Add(sl);
            }
        }
    }
}
