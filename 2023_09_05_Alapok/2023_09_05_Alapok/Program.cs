using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_05_Alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Egy soros komment
            /*
             Több soros komment
             */

            Console.WriteLine("Első sorom a programban. :-)"); 
            // A paraméterben megadott szöveget, változót, objektumokhoz rendelt információkat írja ki a konzolra
            // A kiírt szöveg után, új sorban kezd.

            Console.Write("Második sorom a programban. :-)");
            // A paraméterben megadott szöveget, változót, objektumokhoz rendelt információkat írja ki a konzolra
            // A kurzor az utolsó karaker után lesz elérhető
            Console.WriteLine();


            Console.ReadLine(); // Enter leütésére vár.
            //Console.ReadKey(); // Billentyű leütésére vár.
        }
    }
}
