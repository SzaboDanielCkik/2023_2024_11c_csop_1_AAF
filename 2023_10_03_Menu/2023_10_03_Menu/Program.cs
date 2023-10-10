using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_03_Menu
{
    class Program
    {
        /*static int szam1 = 0;
        static int szam2 = 0;*/

        static void Main(string[] args)
        {
            int szam1 = 0;
            int szam2 = 0;
            int menu;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Két szám megadása");
                Console.WriteLine("2. A két szám összegének kiíratása");
                Console.WriteLine("3. A két szám szorzatának kiíratása");
                Console.WriteLine("0. Kilépés");

                Console.Write("Adjon meg egy menüpontot: ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    //case 1: Szambekeres(); break;
                    case 1: 
                        Szambekeres(ref szam1, ref szam2); 
                        break;
                    case 2:
                        SzamokOsszege(szam1, szam2);
                        break;
                    case 3:
                        SzamokSzorzata(szam1, szam2);
                        break;
                    case 0:
                        Console.WriteLine("A kilépéshez nyomjon egy entert!");
                        break;
                    default: break;
                }
                Console.ReadLine();
            } while (menu != 0);
        }

        static void SzamokSzorzata(int szam1, int szam2)
        {
            Console.Clear();
            int szorzat = Szorzat(szam1, szam2);
            Console.WriteLine("{0} * {1} = {2}", szam1, szam2, szorzat);
            Console.WriteLine("Enter leütése után visszalép a menübe.");
        }

        static int Szorzat(int sz1, int sz2)
        {
            return sz1 * sz2;
        }

        static void SzamokOsszege(int szam1, int szam2)
        {
            Console.Clear();
            Console.WriteLine("{0} + {1} = {2}", szam1, szam2, szam1 + szam2);
            Console.WriteLine("Enter leütése után visszalép a menübe.");
        }

        static void Szambekeres(ref int szam1, ref int szam2)
        {
            Console.Clear();
            Console.WriteLine("Adjon meg két számot: ");
            Console.Write("Szám 1: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Szám 2: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter leütése után visszalép a menübe.");
        }

        /* A main eljárásban csak metódusokra hivatkozunk!
         * - Tömbfeltöltés a felhasználó által megadott értékkel [0,1000]!
         * - Van-e prím a számok között!
         */

    }
}
