using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14_Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(feltétel(ek))
             * {// egy utasítás esetén a zárójel elhagyható
             *      Szekvencia;
             * }
             * else
             * {// egy utasítás esetén a zárójel elhagyható
             *      Szekvencia;
             * }
             * 
             * if(feltétel(ek))
             *  Utasítás;
             * else if(feltétel(ek))
             *  Utasítás;
             * else if(fel....
             * ....
             * else
             *  Utasítás;
             * 
             * if(...)
             *      if(...)...
             *      else...
             * else...
             *      if(...)...
             *      else ....
             *      
             * 
             * switch(változó)
             * {
             *      case eset1: Utasítások;
             *         break;
             *      case eset2: Utasítások;
             *         break;
             *      case eset3: Utasítások;
             *         break;
             *      ....
             *      default: Utasítások;
             *         break;
             * }
             */

            // szilárd<0, 0<=folyadék<100, gáz>100

            Random r = new Random();
            int hofok = r.Next(-100, 201);
            Console.WriteLine(hofok);
            if (hofok < 0)
            {
                Console.WriteLine("szilárd");
            }
            else if (hofok < 100)
            {
                Console.WriteLine("folyadék");
            }
            else
            {
                Console.WriteLine("gáz");
            }

            //pl. nap - edzésterv
            string nap = "csütörtok";
            switch (nap)
            {
                case "hétfő": Console.WriteLine("100 guggolás");
                    break;
                case "kedd": Console.WriteLine("100 fekvő");
                    break;
                case "szerda":
                    Console.WriteLine("200 felülés");
                    break;
                case "csütörtök":
                    Console.WriteLine("pihi");
                    break;
                case "péntek":
                    Console.WriteLine("100 fekvő 100 felülés");
                    break;
                case "szombat":
                    Console.WriteLine("100 kitörés");
                    break;
                case "vasárnap":
                    Console.WriteLine("pihi");
                    break;
                default:
                    Console.WriteLine("Rosszul írta be a napot!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
