using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_26_Tomb2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tomb = new int[] {1,5,4,2,7,5,3 };
            string[] tomb = new string[] {
                "alma","körte", "cseresznye", "szilva", "barack","sárgadinnye", "dinnye"
            };
            // Add meg hányadik helyen van a leghosszabb névvel rendelkező gyümölcs, mi a neve és hány karakter hosszú!

            int maxi = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[maxi].Length < tomb[i].Length)
                {
                    maxi = i;
                }
            }
            Console.WriteLine("{0} gyümölcs a leghosszabb {1}. helyen és {2} karakter hosszú.", tomb[maxi], maxi + 1, tomb[maxi].Length);


            // Írasd ki a gyümölcsöket egymás alatt és mindegyik mellett jelenjen meg a fordított kiíratás.
            // alma - amla
            // körte - etrök

            for (int i = 0; i < tomb.Length; i++)
            {
                /*Console.Write(tomb[i] + " - ");
                for (int j = tomb[i].Length-1; j>=0; j--)
                {
                    Console.Write(tomb[i][j]);
                }
                Console.WriteLine();*/
                /*string ujsz = "";
                for (int j = tomb[i].Length - 1; j >= 0; j--)
                {
                    ujsz += tomb[i][j];
                }
                Console.WriteLine(tomb[i] + " - " + ujsz);*/
                string ujsz = "";
                for (int j = 0; j <tomb[i].Length; j++)
                {
                    ujsz = tomb[i][j] + ujsz;
                }
                Console.WriteLine(tomb[i] + " - " + ujsz);
            }
            // Van-e olyan gyümölcs, amelyik tartalmaz valamilyen betűt! pl. x-et.


            Console.ReadLine();
        }
    }
}
