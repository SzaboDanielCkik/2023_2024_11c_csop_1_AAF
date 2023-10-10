using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_10_Metodusok
{
    class Program
    {
        static int[] t;

        static void Main(string[] args)
        {
            Tombfeltoltes();
            TombKiiratas();
            Feladat1();

            Console.ReadLine();
        }

        static void TombKiiratas()
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write(t[i] + " ");
            Console.WriteLine();
        }

        static void Feladat1()
        {
            if (VanePrim())
            {
                Console.WriteLine("Van a számok között prím.");
            }
            else
            {
                Console.WriteLine("Nincs a számok között prím.");
            }
        }

        static bool VanePrim()
        {
            int i = 0;
            while (i < t.Length && !Prime(t[i]))
                i++;
            return i < t.Length;
        }

        static bool Prime(int a)
        {
            if (a == 2 || a == 3)
                return true;
            else
            {
                int i = 2;
                while (i < a / 2 && a % i != 0)
                    i++;
                return i >= a / 2;
            }

        }

        static void Tombfeltoltes()
        {
            Console.Write("Adja meg hány darab véletlen számot generáljunk: ");
            int n = Convert.ToInt32(Console.ReadLine());
            t = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                t[i] = r.Next(50);
            }
        }

    }
}
