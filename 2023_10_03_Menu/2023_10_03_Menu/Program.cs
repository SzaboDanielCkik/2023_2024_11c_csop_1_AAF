using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_03_Menu
{
    class Program
    {
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
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Adjon meg két számot: ");
                        Console.Write("Szám 1: ");
                        szam1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Szám 2: ");
                        szam2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter leütése után visszalép a menübe.");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("{0} + {1} = {2}", szam1, szam2, szam1 + szam2);
                        Console.WriteLine("Enter leütése után visszalép a menübe.");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("{0} * {1} = {2}", szam1, szam2, szam1 * szam2);
                        Console.WriteLine("Enter leütése után visszalép a menübe.");
                        break;
                    case 0:
                        Console.WriteLine("A kilépéshez nyomjon egy entert!");
                        break;
                    default: break;
                }
                Console.ReadLine();
            } while (menu != 0);
        }
    }
}
