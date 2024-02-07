using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024_02_05_Radio
{
    class Program
    {
        static List<Adas> adasok = new List<Adas>();
        static List<string> uzenetek = new List<string>();
        static void Main(string[] args)
        {
            Fajlbeolvasas(); // 1. feladat
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat7();

            Console.ReadLine();
        }

        private static void Feladat7()
        {
            Console.Write("Adja meg a nap sorszámát! ");
            int nap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a rádióamatőr sorszámát! ");
            int amator = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < adasok.Count && !(adasok[i].nap == nap && adasok[i].amator == amator))
                i++;
            if (i < adasok.Count)
            {
                int db = EgyedekSzama(adasok[i].uzenet);
                if(db>-1)
                    Console.WriteLine("A megfigyelt egyedek száma: {0}", db);
                else
                    Console.WriteLine("Nincs információ");
            }
            else
                Console.WriteLine("Nincs ilyen feljegyzés");
        }

        private static int EgyedekSzama(string uzenet)
        {
            int db = 0;
            string[] st = uzenet.Split('/');
            if (st.Length == 1 || !Szame(st[0])) db = -1;
            else
            {
                db += Convert.ToInt32(st[0]);
                string[] st2 = st[1].Split(' ');
                if (Szame(st2[0]))
                    db += Convert.ToInt32(st2[0]);
                else db = -1;
            }
            return db;
        }

        private static bool Szame(string szo)
        {
            bool valasz = true;
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] < '0' || szo[i] > '9')
                //szo[i]<48 || szo[i]>57
                    valasz = false;
            }
            return valasz;
        }

        private static void Feladat5()
        {
            StreamWriter f = new StreamWriter("adaas.txt");
            for (int i = 1; i < 12; i++)
            {
                uzenetek.Add(UzenetOsszepakolas(i));
                f.WriteLine(uzenetek.Last());
            }
            f.Close();
        }

        private static string UzenetOsszepakolas(int nap)
        {
            string ki = "";
            for (int i = 0; i < 90; i++)
            {
                int j = 0;
                while (j < adasok.Count && !(adasok[j].nap == nap && adasok[j].uzenet[i] != '#'))
                    j++;
                if (j < adasok.Count)
                    ki += adasok[j].uzenet[i];
                else
                    ki += "#";
            }
            return ki;
        }

        private static void Feladat4()
        {
            Console.WriteLine("\n4. feladat");
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine("{0}. nap: {1} rádióamatőr", i, RadioAmatorDarabszam(i));
            }
        }

        private static int RadioAmatorDarabszam(int nap)
        {
            int db = 0;
            for (int i = 0; i < adasok.Count; i++)
                if (adasok[i].nap == nap) db++;
            return db;
        }

        private static void Feladat3()
        {
            Console.WriteLine("\n3. feladat");
            for (int i = 0; i < adasok.Count; i++)
            {
                if(adasok[i].VaneFarkasUzenetben())
                    Console.WriteLine("{0}. nap {1}. rádióamatőr",adasok[i].nap, adasok[i].amator);
            }
        }

        static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("Az első üzenet rögzítője: {0}", adasok[0].amator);
            //Console.WriteLine("Az utolsó üzenet rögzítője: {0}",adasok[adasok.Count-1].amator);
            Console.WriteLine("Az utolsó üzenet rögzítője: {0}",adasok.Last().amator);
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("veetel.txt");
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                //Adas sv = new Adas(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), f.ReadLine());
                //adasok.Add(sv);
                adasok.Add(new Adas(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), f.ReadLine()));
            }
            f.Close();
        }
    }

    struct Adas
    {
        // Mezők
        public int nap, amator;
        public string uzenet;

        // Konstruktor
        public Adas(int nap, int amator, string uzenet)
        {
            this.nap = nap;
            this.amator = amator;
            this.uzenet = uzenet;
        }

        // Metódusok
        public bool VaneFarkasUzenetben()
        {
            return uzenet.Contains("farkas");
        }

    }
}
