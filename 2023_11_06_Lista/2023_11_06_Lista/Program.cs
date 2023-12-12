using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_06_Lista
{
    class Program
    {
        /*
        List<tipus> lista_neve;
        List<tipus> lista_neve = new List<tipus>();
        List<tipus> lista_neve = new List<tipus>(){12,11,9};
        */

        static List<int> parosak = new List<int>();
        static void Main(string[] args)
        {
            /*
            parosak.Add(12);
            Console.WriteLine(parosak[0]);
            int elemszam = parosak.Count;*/
            ListaFeltoltes(11); //[10,99] - párosak
            ListaKiir();
            BeepitettFuggvenyek();


            Console.ReadLine();
        }

        static void BeepitettFuggvenyek()
        {
            //Első elemre hivatkozás
            Console.WriteLine("Első elem: " + parosak.First());
            //Utolsó elemre hivatkozás
            Console.WriteLine("Utolsó elem: " + parosak.Last());
            //Törlés első megadott érték, ami a listában van
            parosak.Remove(24);
            ListaKiir();
            //Törlés index alapján
            parosak.RemoveAt(2);
            ListaKiir();

            //Dolgozatban nem használhatod!!!!!!!!
            int min = parosak.Min();
            int max = parosak.Max();
            //rendezés
            parosak.Sort();

            // Megadja a paraméterben megadott érték indexét, ha van
            // különben -1 az érték
            int index = parosak.IndexOf(24);

            // Megadja, hogy van-e az adott érték a listában.
            bool vane = parosak.Contains(24);

        }

        static void ListaKiir()
        {
            for (int i = 0; i < parosak.Count; i++)
                Console.Write(parosak[i]+" ");
            //parosak.ForEach(c => Console.Write(c + " "));
            Console.WriteLine();
        }

        static void ListaFeltoltes(int elemszam)
        {
            Random r = new Random();
            for (int i = 0; i < elemszam; i++)
            {
                parosak.Add(r.Next(5, 50) * 2);
            }
        }

    }
}
