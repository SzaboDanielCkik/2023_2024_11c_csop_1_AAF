using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_29_RekurzivMatrix
{
    class Program
    {
        static string[,] t = new string[20, 20];
        static void Main(string[] args)
        {
            MatrixFeltoltes();
            MatrixKiir();

            SzigetekMegszamolasa();
            Console.WriteLine();
            MatrixKiir();

            Console.ReadLine();
        }

        private static void SzigetekMegszamolasa()
        {
            int db = 0;
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (t[i, j] == "X")
                    {
                        RekSzigetFelismeres(i, j,db);
                        db++;
                    }
                }
            }
            Console.WriteLine(db);
        }

        private static void RekSzigetFelismeres(int s, int o, int db)
        {
            t[s, o] = "" + db;
            if (s - 1 >= 0 && t[s - 1, o] == "X") RekSzigetFelismeres(s - 1, o,  db);
            if (o + 1 < t.GetLength(1) && t[s, o+1] == "X") RekSzigetFelismeres(s, o+1, db);
            if (s + 1 < t.GetLength(0) && t[s+1, o] == "X") RekSzigetFelismeres(s+1, o, db);
            if (o - 1 >=0 && t[s, o - 1] == "X") RekSzigetFelismeres(s, o - 1, db);
        }

        private static void MatrixKiir()
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write(t[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void MatrixFeltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (r.Next(10) < 4)
                        t[i, j] = "X";
                    else
                        t[i, j] = ".";
                }
            }
        }
    }
}
