using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_20_Sziget2
{
    class Program
    {
        static List<int> meresek = new List<int>();
        static void Main(string[] args)
        {
            //BemenetiErtekek();
            BemenetiErtekek2();
            Feladat();

            Console.ReadLine();
        }

        static void Feladat()
        {
            int i = 1, A, B, C, bal = -1, jobb = -1;
            bool csucs = false;
            do {
                A = meresek[i];
                B = meresek[i + 1];
                C = meresek[i + 2];

                if (A == 0 && B > 0) bal = i + 1;
                if (B > 0 && C == 0) jobb = i + 1;
                csucs = A > 0 && B > A && C > 0 && B > C;
                if (csucs)
                {
                    bal = -1;
                    jobb = -1;
                }
                i++;
            } while(i<meresek.Count-2 && !csucs && jobb<0);
            Console.WriteLine("{0} {1}", bal + 1, jobb + 1);
        }

        static void BemenetiErtekek()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] st = Console.ReadLine().Split(' ');
            for (int i = 0; i < st.Length; i++)
            {
                meresek.Add(Convert.ToInt32(st[i]));
            }
        }

        static void BemenetiErtekek2()
        {
            Random r = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
				// 80%-os valószínűséggel generál 0 értéket.
                if (r.Next(1, 101) <= 80)
                    meresek.Add(0);
                else
                    meresek.Add(r.Next(1, 91) * 100);
                //Console.Write(meresek.Last()+" ");
            }
        }
    }
}

/*
12
3 0 1 3 5 6 0 2 5 6 0 2 
*/