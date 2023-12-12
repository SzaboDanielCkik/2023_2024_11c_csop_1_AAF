using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_09_Metszet
{
    class Program
    {
        static List<int> A = new List<int>();
        static List<int> B = new List<int>();
        static Random r = new Random();
        static void Main(string[] args)
        {
            /* Készítsen egy listafeltöltés eljárást, ami függ egy üres listától és egy elemszámtól és feltölti [1,100] közötti véletlen nem ismétlő számmal! 
             * Töltsön fel két külön elemszámú listát!
             * Határozza meg a két lista metszetének eredményét!*/

            ListaFeltoltes(A, 15);
            ListaFeltoltes(B, 15);
            ListaKiir(A);
            ListaKiir(B);

            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadLine();
        }

        static void Feladat3()
        {
            A.Sort();
            B.Sort();
            List<int> osszefuz = new List<int>();

            int i = 0, j = 0;
            while (i < A.Count && j < B.Count)
            {
                if (A[i] < B[j])
                {
                    osszefuz.Add(A[i++]);
                    //i++;
                }
                else if (A[i] > B[j])
                {
                    osszefuz.Add(B[j++]);
                    //j++;
                }
                else
                {
                    osszefuz.Add(B[j++]);
                    //j++;
                    i++;
                }
            }
            if (i < A.Count)
                for (int k = i; k < A.Count; k++)
                    osszefuz.Add(A[k]);
            else 
                for (int k = j; k < B.Count; k++)
                    osszefuz.Add(B[k]);
            ListaKiir(osszefuz);
        }

        static void Feladat2()
        {
            List<int> unio = Unio(A, B);
            ListaKiir(unio);
        }

        static List<int> Unio(List<int> lista1, List<int> lista2)
        {
            List<int> unio = new List<int>();
            for (int i = 0; i < lista1.Count; i++)
                unio.Add(lista1[i]);
            //foreach (int elem in lista1) unio.Add(elem);

            for (int i = 0; i < lista2.Count; i++)
            {
                if (!ListabanVane(unio, lista2[i]))
                    unio.Add(lista2[i]);
            }

            return unio;
        }

        static void Feladat1()
        {
            List<int> metszet = Metszet(A, B);
            ListaKiir(metszet);
        }

        static List<int> Metszet(List<int> lista1, List<int> lista2)
        {
            List<int> metszet = new List<int>();
            for (int i = 0; i < lista1.Count; i++)
            {
                if (ListabanVane(lista2, lista1[i]))
                    metszet.Add(lista1[i]);
            }
            return metszet;
        }

        static void ListaKiir(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i]+" ");
            Console.WriteLine();
        }

        static void ListaFeltoltes(List<int> lista, int db)
        {
            /*Random r = new Random();
            System.Threading.Thread.Sleep(10);*/
            while (lista.Count < db)
            {
                int rnd = r.Next(1, 20);
                if(!ListabanVane(lista, rnd))
                    lista.Add(rnd);
            }
        }

        static bool ListabanVane(List<int> lista, int szam)
        {
            int i = 0;
            while (i < lista.Count && lista[i] != szam)
                i++;
            return i < lista.Count;
        }

    }
}
