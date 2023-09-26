using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_22_Karakterlanc3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adott egy szöveg. Kérj be a felhasználótól két betűt és nézd meg, hogy van-e a szövegben!

            string sz = "pilács";
            string betuk = "sz";

            int i = 0;
            while (i < sz.Length-1 && !(sz[i] == betuk[0] && sz[i+1] == betuk[1]))
                i++;
            if (i < sz.Length-1)
                Console.WriteLine("Vannak benne " + betuk + " betűk.");
            else
                Console.WriteLine("Nincsenek benne " + betuk + " betűk");

            /* !(A és B) = !A vagy !B
             * !(A vagy B) !A és !B*/


            Console.ReadLine();
        }
    }
}
