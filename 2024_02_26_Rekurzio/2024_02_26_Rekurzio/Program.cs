using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_26_Rekurzio
{
    class Program
    {
        static List<int> lista = new List<int>();
        static Random r = new Random();
        static void Main(string[] args)
        {
            /* Rekurzió - metódus, ami meghívja önmagát.
               
               Program(n)
                    folyamat;
                    Program(n+1);
               pr.v.
            */

            int n = 6;
            // n! = n * (n-1) * (n-2) * ....* 2 * 1
            Console.WriteLine(FaktorIterativan(n));
            // n! = n * (n-1)!


            Console.WriteLine(FaktorRekurzivan(n));

            Console.WriteLine(FibonacciIterativan());
            Console.WriteLine(FibonacciRekurzivan(10));
            Kiiratas(10);
            // Eljárás Rekurzívan, listafeltöltés(db)
            // FV Rekurzívan, egy összegzés tételét (ciklus változó)!

            RekurzivListaFeltoltes(5);
            Console.WriteLine("\nA számok összge: "+RekurzivOsszegzes(0));

            Console.ReadLine();
        }

        static int RekurzivOsszegzes(int n)
        {
            if (n < lista.Count)
            {
                return lista[n] + RekurzivOsszegzes(n + 1);
            }
            return 0;
        }

        static void RekurzivListaFeltoltes(int n)
        {
            if (n > 0)
            {
                lista.Add(r.Next(0,5));
                RekurzivListaFeltoltes(n - 1);
            }
        }

        static void Kiiratas(int n)
        {
            Console.Write(n + " ");
            if (n > 1)
                Kiiratas(n - 1);
        }

        static int FibonacciRekurzivan(int n)
        {
            if (n < 3)
            {
                return n;
            }
            else
                return FibonacciRekurzivan(n - 1) + FibonacciRekurzivan(n - 2);
        }

        static int FibonacciIterativan()
        {
            List<int> fib = new List<int> {0,  1 };
            int n = 10;
            for (int i = 2; i < n; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }
            return fib.Last();
        }

        static int FaktorRekurzivan(int n)
        {
            if (n > 0) return n * FaktorRekurzivan(n - 1);
            else return 1; 
        }

        static int FaktorIterativan(int n)
        {
            int fakt = 1;
            for (int i = 1; i <= n; i++)
            {
                fakt *= i;
            }
            return fakt;
        }
    }
}
