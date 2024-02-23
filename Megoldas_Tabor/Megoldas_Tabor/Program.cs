using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megoldas_Tabor
{
    class Program
    {
        static List<Tabor> t = new List<Tabor>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            Feladat4();
            Console.ReadLine();
        }

        private static void Feladat4()
        {
            List<int> index = MaxJelentkezokIndexe();
            Console.WriteLine("4. feladat");
            for (int i = 0; i < index.Count; i++)
            {
                Console.WriteLine("Legnépszerűbbek: {0} {1} {2}", t[index[i]].kh, t[index[i]].kn, t[index[i]].tnev);
            }        
        }

        private static List<int> MaxJelentkezokIndexe()
        {
            List<int> indexek = new List<int>();
            int maxi = 0;
            for (int i = 1; i < t.Count; i++)
            {
                if (t[i].jelentkezok.Length > t[maxi].jelentkezok.Length)
                {
                    indexek.Clear();
                    maxi = i;
                    indexek.Add(maxi);
                }
                else if (t[i].jelentkezok.Length == t[maxi].jelentkezok.Length)
                {
                    indexek.Add(i);
                }
            }
            return indexek;
        }

        private static int Sorszam(int h, int n)
        {
            int napok = 0;


            return napok;
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            List<Tabor> taborok = TaborIdopontok("zenei");
            for (int i = 0; i < taborok.Count; i++)
            {
                Console.WriteLine("Zenei tábor kezdődik {0}.hó {1}.napján.",
                    taborok[i].kh,taborok[i].kn);
            }        
        }

        private static List<Tabor> TaborIdopontok(string tipus)
        {
            List<Tabor> taborok = new List<Tabor>();
            for (int i = 0; i < t.Count; i++)
            {
                if (t[i].tnev == tipus)
                    taborok.Add(t[i]);
            }
            return taborok;
        }


        private static void Feladat2()
        {
            Console.WriteLine("2. feladat\nAz adatsorok száma: {0}\nAz először rögzített tábor témája: {1}\nAz utoljára rögzített tábor témája: {2}",
                t.Count,t.First().tnev,t.Last().tnev);
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("taborok.txt");

            while (!f.EndOfStream)
                t.Add(new Tabor(f.ReadLine()));

            f.Close();
        }
    }

    struct Tabor
    {
        //mezők
        public int kh, kn, vh, vn;
        public string jelentkezok, tnev;

        //konstruktor
        public Tabor(string sor)
        {
            string[] st = sor.Split('\t');
            kh = Convert.ToInt32(st[0]);
            kn = Convert.ToInt32(st[1]);
            vh = Convert.ToInt32(st[2]);
            vn = Convert.ToInt32(st[3]);
            jelentkezok = st[4];
            tnev = st[5];
        }
    }
}
