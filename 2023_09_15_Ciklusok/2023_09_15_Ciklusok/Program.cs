using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_15_Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Számlálós ciklus
             * ciklus i = kezdőérték - meddig léptetés
             *      Ciklus Mag
             * ciklus vége
             * 
             * for(int i = 0; i<n; i++) // n-1-ig megy, i+=1 egyesével
             * { //egy utasítás esetén a zárójel elhagyható
             *      Ciklus Mag
             * }
             * 
             * Tesztelős ciklusok
             * Elől tesztelős
             * i = 0;
             * Ciklus amíg (belépés feltétele)
             * {
             *      Ciklus Mag
             *      i léptetése;
             * }
             * 
             * int i = 0;
             * while(i<n && Ttul(random))
             * {
             *      random;
             *      i++;
             * }
             * 
             * Hátul tetsztelős
             * Ciklus
             *      Ciklus Mag
             * Amíg(benmaradás feltétele);
             * 
             * do
             * {
             *      Ciklus Mag
             * }while(benmaradás feltétele);
             */

            Console.Write("Hány darab értéket jelenítsünk meg a sorozatból? ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(2 + (3 * i) + " ");
            }
            Console.WriteLine();

            // Kérjen be a felhasználótól egy értéket és addig írassa ki a következő sorozat értékeit! (A bekért számnál kisebb értékeket!)
            // n = 100
            // 2 8 18 32 50 72 98
            // 1 4 9  16 25 36 49
            // 1 2 3  4  5  6  7

            Console.WriteLine("Adjon meg egy értéket és a sorozat elemeit addig kiíom: ");
            n = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            while ((j*j*2) < n)
            {
                Console.Write(j*j*2+" ");
                j++;
            }
            Console.WriteLine();
            // Addig írassa ki a véletlen számokat [1,100] között, amíg 7-tel oszthatót nem kap.

            Random r = new Random();
            int szam;
            do {
                szam = r.Next(1, 101);
                Console.Write(szam + " ");
            } while (szam % 7  != 0);

            // HF 26, 27

            Console.ReadLine();
        }
    }
}
