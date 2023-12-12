using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_07_ListaGyakorlas
{
    class Program
    {
        static List<int> t = new List<int>();
        static void Main(string[] args)
        {
            /*  Töltsön fel egy listát a felhasználó által bekért   értékkel [10,1000] közötti értéket adhat meg.
                A véletlen számok [1,1000] között és 6-tal osztható számok legyenek. 
                Szürje meg a listát, mindegyik számból egy szerepeljen!
                Rendezze a szűrt listát!*/
            ListaFeltolt();
            Szures();

            Console.ReadLine();

        }

        static void Szures()
        {
            /*HashSet<int> halmaz = new HashSet<int>();
            halmaz = t.ToHashSet();*/
            //List<int> szurtelemek = t.ToHashSet().ToList();

            List<int> szurtelemek = new List<int>();
            for (int i = 0; i < t.Count; i++)
            {
                int j = 0;
                while (j < szurtelemek.Count && szurtelemek[j] != t[i])
                    j++;
                if (j >= szurtelemek.Count)
                    szurtelemek.Add(t[i]);
            }

        }

        static void ListaFeltolt()
        {
            int n = ElemszamBekerese();
            Random r = new Random();
            for (int i = 0; i < n; i++)
                t.Add(r.Next(1, 10) * 6);
        }

        static int ElemszamBekerese()
        {
            int db;
            do
            {
                Console.WriteLine("Adjon meg egy számot [10,1000] között: ");
                db = Convert.ToInt32(Console.ReadLine());
            } while (db < 10 || db > 1000);
            return db;
        }
    }
}
