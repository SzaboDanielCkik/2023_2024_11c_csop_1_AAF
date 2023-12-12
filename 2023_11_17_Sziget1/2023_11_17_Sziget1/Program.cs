using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_17_Sziget1
{
    class Program
    {
        static List<int> meresek = new List<int>();
        static void Main(string[] args)
        {
            //Console.WriteLine("Adja meg az értékeket szóközzel elválasztva.");
            //string szoveg = Console.ReadLine() ;
            //Split, megadott karakter alapján darabol. Tömböt ad vissza eredményül.
            /*string[] st = Console.ReadLine().Split(' ');
            for (int i = 0; i < st.Length; i++)
                Console.WriteLine(st[i] + " ");*/

            AdatokBekerese();
            Feladat();

            Console.ReadLine();
        }
        
        static void Feladat()
        {
            int max = 0;
            int db = 0;
            for (int i = 1; i < meresek.Count-1; i++)
            {
                if (meresek[i] == 0) db++;
                else
                {
                    if (db > max) max = db;
                    db = 0;
                }
            }
            Console.WriteLine("A leghosszabb tengerhossz szélessége: " + max);
        }


        static void AdatokBekerese()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] st = Console.ReadLine().Split(' ');
            for (int i = 0; i < st.Length; i++)
            {
                meresek.Add(Convert.ToInt32(st[i]));
            }
        }

    }
}

/*
12
2 0 0 0 0 1 0 2 5 0 0 2
  
*/
