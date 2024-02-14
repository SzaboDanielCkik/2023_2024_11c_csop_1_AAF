using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024_02_12_KockadobasStatisztika
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Szimuláljunk egy kockadobást és nézzük meg, hogy tényleg egyenlő valószínűséggel dobjuk ki a számokat!
             * Metódus: Feltölt egy n elemű listát kockadobással (6 oldalú kocka)!
             * Függvény: Egy szám hányszor fordult elő a dobások alkalmával!
             * Feladat1: 10 dobásonként, hogyan alakulnak a számok! 
             * Feladat2: Készítsen egy diagrammot a megjelenítéshez!*/

            //Console.SetCursorPosition(hányat akarsz jobbra lépni, lefele);
            Random r = new Random();
            Console.CursorVisible = false;
            for (int j = 0; j < 50; j++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(r.Next(50), r.Next(20));
                    Console.BackgroundColor = ConsoleColor.Green;
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }
                Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
