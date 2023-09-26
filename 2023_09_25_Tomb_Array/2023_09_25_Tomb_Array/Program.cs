using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_25_Tomb_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Összetett Adaszerkezetek:
             * Tömb, lista, verem, sor, könyvtár, halmaz,...
             * Tömb:
             * típus[] tömb_név = new típus[elemszám];
             * pl.
             * int[] tomb = new int[13]; 
               tomb[0] = érték;
               ciklus i = 0-tomb.Length-ig egyesével
                    tomb[i] = érték;
                    Console.Write(tomb[i]+" ");
               c.v.             
             */

            // Töltsünk fel egy 13 elemű tömböt [50,2000] között 50-nel osztható számokkal!

            // Völgynek hívjuk azt az értéket, ami a szomszédos értékektől kisebb. Van-e völgy a mért értékek között!

            int[] t = new int[13];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(1, 41) * 50;
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();

            int j = 1;
            bool vane = false;
            while (j < t.Length - 1 && !(t[j] < t[j - 1] && t[j] < t[j + 1]))
            {
                j++;
            }
            vane = j < t.Length - 1;
            if (vane)
            {
                Console.WriteLine("Van a mért értékek között völgy.");
            }
            else
            {
                Console.WriteLine("Nincs a mért értékek között völgy.");
            }


            // Ha van völgy a mért értékek között, mond meg hányadik helyen a van a legkisebb!

            if (vane)
            {
                int mine = t[1];
                int mini = 1;
                for (int i = 2; i < t.Length-1; i++)
                {
                    if (mine > t[i] && t[i] < t[i - 1] && t[i] < t[i + 1])
                    {
                        mine = t[i];
                        mini = i;
                    }
                }
                Console.WriteLine("{0}. helyen van a legkisebb völgy értéke.", mini+1);
            }

            Console.ReadLine();
        }
    }
}
