using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_12_Konvertalas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konzolról való adat bekérés
            /*Console.Write("Adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}!", nev);
            Console.Write("Add meg melyik évben születtél: ");
            string beEv = Console.ReadLine();
            int ev = Convert.ToInt32(beEv);
            Console.WriteLine("Ebben az évben {0} éves leszel.", 
                2023 - ev);

            Console.WriteLine(2023 - int.Parse(beEv));*/

            Console.WriteLine(Convert.ToInt32(true));
            Console.WriteLine(Convert.ToBoolean(1));

            double a = -23.5;
            Console.WriteLine(a);
            Console.WriteLine(Convert.ToInt32(a));//Matematikai szabálynak megfelelően kerekít
            Console.WriteLine((int)a);

            int c = 13;
            Console.WriteLine((double)c / 3);

            //Szöveggé konvertálási lehetőségek
            string szoveg = ""+c;
            szoveg = c.ToString();
            szoveg = Convert.ToString(c);

            //szöveget lebegőpontossá
            string beTort = "23,9";
            double tort = Convert.ToDouble(beTort);
            Console.WriteLine(tort);

            // Matematikai függvények

            Random r = new Random();
            double szam = r.Next(-10, 11);
            Console.WriteLine($"A szám: {szam}");
            Console.WriteLine("Abszolut értéke: " + Math.Abs(szam));
            Console.WriteLine("Négyzetgyök: " + Math.Sqrt(szam));
            Console.WriteLine("Hatványozás, köbre emelés: " + Math.Pow(szam,3));
            Console.WriteLine("Pi: {0}",Math.PI);
            Console.WriteLine("Sin({0}): {1}", szam, Math.Sin(szam));

            //Kerekítések
            double e = Math.E;
            Console.WriteLine("Ceiling: " + Math.Ceiling(e)); // Felső egész rész
            Console.WriteLine("Floor: " + Math.Floor(e)); // Alsó egész rész
            Console.WriteLine("Round: " + Math.Round(e,2)); // Matematikai szabályoknak megfelelően









            Console.ReadLine();
        }
    }
}
