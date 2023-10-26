using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_17_Rendezes
{
    class Program
    {
        static int[] t = new int[10];
        static void Main(string[] args)
        {
            TombFeltoltes(t);
            TombKiiratas(t);
            Rendezes(t);
            TombKiiratas(t);

            Console.ReadLine();
        }

        static void Rendezes(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j]) Csere(ref tomb[i], ref tomb[j]);
                }
            }
        }

        static void Csere(ref int a, ref int b)
        {
            int sv = a;
            a = b;
            b = sv;
        }

        static void TombKiiratas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }

        static void TombFeltoltes(int[] tomb)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = r.Next(10, 1000);
        }

    }
}
