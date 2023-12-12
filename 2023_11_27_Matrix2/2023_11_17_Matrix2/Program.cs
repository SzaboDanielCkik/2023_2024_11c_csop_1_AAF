using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_17_Matrix2
{
    class Program
    {
        static int[,] t = new int[4, 6]; //[sor, oszlop]
        static int[,] transp;
        static void Main(string[] args)
        {
            /* Töltsön fel egy 4x6-os (sor x oszlop) adatszerkezetet [0,100] közötti számokkal, úgy, hogy 60%os valószínűséggel generál 0-t; (60% - 0 ; 40% - [1,100] )
             * Adja meg, melyik sornál legnagyobb a számok átlaga!
               A legkisebb átlagú oszlop indexe(helye)!
             */

            Feltoltes();
            MatrixKiir(t);
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();

            Console.ReadLine();

        }

        static void Feladat4()
        {
            int[,] szorzatMatrix = MatrixSzorzat(t, transp);
            MatrixKiir(szorzatMatrix);
        }

        static int[,] MatrixSzorzat(int[,] A, int[,] B)
        {
            int[,] szorzat = new int[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    szorzat[i, j] = SzorzatOsszeg(A, i, B, j);
                }
            }
            return szorzat;
        }

        static int SzorzatOsszeg(int[,] M, int sor, int[,] N, int oszlop)
        {
            int sum = 0;
            for (int i = 0; i < M.GetLength(1); i++)
            {
                sum += M[sor, i] * N[i, oszlop];
            }
            return sum;
        }

        static void Feladat3()
        {
            transp = Transponalas(t);
            MatrixKiir(transp);
        }

        static int[,] Transponalas(int[,] matrix)
        {
            int[,] transponalt = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    transponalt[j, i] = matrix[i, j];
            return transponalt;                    
        }

        static void Feladat2()
        {
            int mini = 0;
            double mine = 101;
            for (int i = 0; i < t.GetLength(1); i++)
            {
                double a = OszlopAtlag(t, i);
                if (a < mine)
                {
                    mini = i;
                    mine = a;
                }
            }
            Console.WriteLine("{0}. oszlop a legkisebb átlagú.", mini + 1);
        }

        static double OszlopAtlag(int[,] matrix, int oszlop)
        {
            double osszeg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                osszeg += matrix[i, oszlop];
            return osszeg / matrix.GetLength(0);
        }


        static void Feladat1()
        {
            int maxi = 0;
            double maxe = 0;
            for (int i = 0; i < t.GetLength(0); i++)
            {
                double a = SorAtlag(t, i);
                if (a > maxe)
                {
                    maxi = i;
                    maxe = a;
                }
            }
            Console.WriteLine("{0}. sor a legnagyobb átlagú.", maxi + 1);
        }

        static double SorAtlag(int[,] matrix, int sor)
        {
            double osszeg = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                osszeg += t[sor, j];
            return osszeg / matrix.GetLength(1);
        }

        static void MatrixKiir(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Feltoltes()
        {
            Random r = new Random();
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (r.Next(1, 101) <= 60)
                        t[i, j] = 0;
                    else
                        t[i, j] = r.Next(1, 101);
                }
            }
        }
    }
}
