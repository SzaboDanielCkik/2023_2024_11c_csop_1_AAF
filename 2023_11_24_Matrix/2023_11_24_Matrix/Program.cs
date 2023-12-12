using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_24_Matrix
{
    class Program
    {
        static int[,] matrix = new int[2, 3];
        static void Main(string[] args)
        {
            /* 2D adatszerkezet - Mátrix nxm
               típus[,] 2d_matrix = new típus[n,m];
               típus[,] 2dm;
                ...
               2dm = new típus[n,m];*/

            //MatrixAlapok();

            Feladat1();

            // 1. Feladat - Kérjen be a felhasználótól két db két ismeretlenes egyenelet (pl 2x+13y=5, 5x+11y=0) Adja meg a feladat mátrixát! 
            //2 13 5
            //5 11 0

            Console.ReadLine();
        }

        static void Feladat1() {
            Console.WriteLine("Adja meg az első képletet:");
            string sor1 = Console.ReadLine();
            //Console.WriteLine("Adja meg a második képletet:");
            //string sor2 = Console.ReadLine();
            //string[] st = sor1.Split('+'); //2x 13y=5
            /*string[] st = sor1.Split('x','+','y','='); //2| |13| |5
            string[] st2 = sor2.Split('x', '+', 'y', '='); //2| |13| |5
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[0, i] = Convert.ToInt32(st[i * 2]);
                matrix[1, i] = Convert.ToInt32(st2[i * 2]);
            }*/
            int k = 0;
            string a ="";
            for (int i = 0; i < sor1.Length; i++)
            {
                if (Szame(sor1[i]))
                    a += sor1[i];
                if (sor1[i] == 'x' || sor1[i] == 'y')
                {
                    matrix[0, k] = Convert.ToInt32(a);
                    k++;
                    a = "";
                }
            }
            matrix[0, k] = Convert.ToInt32(a);
        }

        static bool Szame(char c)
        {
            return c >= 48 && c <= 57;
        }

        static void MatrixAlapok()
        {
            // [sor, oszlop]
            int[,] matrix = new int[3, 4];
            matrix[0, 0] = 13;
            matrix[0, 3] = 12;
            // matrix.Length = sorokSzama*oszlopokSzama
            int sorokSzama = matrix.GetLength(0);
            int oszlopokSzama = matrix.GetLength(1);

            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
