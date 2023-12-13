using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_11_Gyakorlas
{
    class Program
    {
        static Random r = new Random();
        static int[,] matrix;
		
        static void Main(string[] args)
        {
            // Töltsön fel egy NxN-es mátrixot egyjegyű egész számokkal [-9,9].
            // 1. Adja meg a fő és mellék átlók összegét!
            // 2. Adja meg az aktuális sor és aktuális oszlop legnagyobb értékeinek átlagát! (pl. 0. sor 0. oszlop legnagyobb elemeinek átlaga, stb.
            // 3. Adja meg a mátrix és a mátrix transponáltjának különbségét!
            // Az adott indexű értéket kivonod az adott indexű értékből.

            Feltoltes(ref matrix);
            Kiiratas(matrix);
            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadLine();

        }

        static void Feladat3()
        {
            int[,] transponalt = Transponalas(matrix);
            Kiiratas(transponalt);
            int[,] kulonbseg = MatrixKulonbseg(matrix, transponalt);
            Kiiratas(kulonbseg);
        }

        static int[,] MatrixKulonbseg(int[,] mat1, int[,] mat2)
        {
            int[,] m = new int[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    m[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            return m;
        }

        static int[,] Transponalas(int[,] mat)
        {
            int[,] m = new int[mat.GetLength(1), mat.GetLength(0)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    m[j, i] = mat[i, j];
                }
            }
            return m;
        }

        static void Feladat2()
        {
            Console.WriteLine("2.feladat:");
            List<double> atlagok = new List<double>();
            MaxAtlagokKigyujtese(atlagok);
            KiirLista(atlagok);
        }

        static void MaxAtlagokKigyujtese(List<double> atlagok)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sormax = SorMaximuma(i);
                int oszlopmax = OszlopMaximuma(i);
                atlagok.Add((double)(sormax + oszlopmax) / 2);
            }
        }

        static int OszlopMaximuma(int oszlop)
        {
            int maxe = -1000;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, oszlop] > maxe)
                    maxe = matrix[i, oszlop];
            }
            return maxe;
        }

        static int SorMaximuma(int sor)
        {
            int maxe = -1000;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[sor, i] > maxe)
                    maxe = matrix[sor, i];
            }
            return maxe;
        }

        static void KiirLista(List<double> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0}. sor-oszlop max átlag: {1}", i + 1, lista[i]);
            }
        }



        static void Feladat1()
        {
            Console.WriteLine("1.feladat:");
            Console.WriteLine("Az átlók összege: " + AtlokOsszege(matrix));
        }

        static int AtlokOsszege(int[,] mat)
        {
            int foatlo = 0;
            int mellekatlo = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                foatlo += mat[i, i];
                mellekatlo += mat[i, mat.GetLength(0) - 1 - i];
            }
            return foatlo + mellekatlo;
        }

        static void Kiiratas(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Feltoltes(ref int[,] mat)
        {
            int n = r.Next(3, 4);
            mat = new int[n, n];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(-9, 10);
                }
            }
        }
    }
}
