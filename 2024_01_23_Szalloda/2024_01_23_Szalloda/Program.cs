using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_23_Szalloda
{
    class Program
    {
        // 27 szoba, 2 ágyas + pótágy, tavaszi-nyári-őszi
        // szoba ára - 1 főnél teljes

        static List<Foglalas> foglalasok = new List<Foglalas>();
        static List<Honap> honapok = new List<Honap>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            FajlbeolvasasHonapok();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();

            Console.ReadLine();
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat");
            Console.Write("Adja meg a foglalás kezdő dátumának sorszámát [1,365]: ");
            int napSorszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az éjszakák számát: ");
            int napokSzama = Convert.ToInt32(Console.ReadLine());
            SzabadSzobakMeghatarozasa(napSorszam, napokSzama);
        }

        private static void SzabadSzobakMeghatarozasa(int kezdes, int napok)
        {
            for (int i = 1; i < 28; i++)
            {
                int j = 0;
                while (j < foglalasok.Count &&
                    (foglalasok[j].szobaszam != i ||
                    !(foglalasok[j].erkezes <= kezdes && foglalasok[j].tavozas >= kezdes) &&
                    !(foglalasok[j].erkezes <= kezdes + napok && foglalasok[j].tavozas>= kezdes+ napok) &&
                    !(foglalasok[j].erkezes >= kezdes && foglalasok[j].tavozas <= kezdes + napok)))
                    j++;
                if (j >= foglalasok.Count)
                    Console.WriteLine(i);

            }
        }

        private static void FajlbeolvasasHonapok()
        {            
            StreamReader f = new StreamReader("honapok.txt");
            while (!f.EndOfStream)
            {
                honapok.Add(new Honap(f.ReadLine(), f.ReadLine(), f.ReadLine()));
            }
            f.Close();
        }

        static void Feladat4()
        {
            Console.WriteLine("4. feladat");
            int[] honapSorszam = new int[12];
            for (int i = 0; i < honapok.Count; i++)
            {
                int db = 0;
                for (int j = 0; j < foglalasok.Count; j++)
                {
                    //120-124
                    //április honap 91-120 91+30
                    //május honap 121-151 121+31
                    //0-4
                    if (foglalasok[j].erkezes < honapok[i].kezdes + honapok[i].napokSzama)
                    {
                        if (foglalasok[j].erkezes >= honapok[i].kezdes && foglalasok[j].tavozas < honapok[i].kezdes + honapok[i].napokSzama)
                            db += (foglalasok[j].tavozas - foglalasok[j].erkezes) * foglalasok[j].vendegekSzama;
                        else if (foglalasok[j].erkezes >= honapok[i].kezdes && foglalasok[j].tavozas >= honapok[i].kezdes + honapok[i].napokSzama)
                        {
                            db += (honapok[i].kezdes + honapok[i].napokSzama - foglalasok[j].erkezes) * foglalasok[j].vendegekSzama;
                        }
                        else if (foglalasok[j].erkezes < honapok[i].kezdes && foglalasok[j].tavozas >= honapok[i].kezdes)
                        {
                            db += (foglalasok[j].tavozas - honapok[i].kezdes) * foglalasok[j].vendegekSzama;
                        }
                    }
                }
                honapSorszam[i] = db;
            }
            TombKiiratas(honapSorszam);
        }
        static void TombKiiratas(int[] tomb) {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"{i+1}: {tomb[i]} vendégéj");
            }
        }

        static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            StreamWriter w = new StreamWriter("bevetel.txt");
            int osszeg = 0;
            for (int i = 0; i < foglalasok.Count; i++)
            {
                w.WriteLine("{0}: {1}", foglalasok[i].sorszam, foglalasok[i].FizetendoOsszeg());
                osszeg += foglalasok[i].FizetendoOsszeg();
            }
            Console.WriteLine(osszeg);
            w.Close();
        }

        private static void Feladat2()
        {
            Console.WriteLine("2. feladat");
            Foglalas legtobb = MaxEltoltottEjszakak();
            Console.WriteLine("{0} ({1}) - {2}",legtobb.nev, legtobb.erkezes, legtobb.ejszakakSzama);
        }

        static Foglalas MaxEltoltottEjszakak()
        {
            int maxi = 0;
            for (int i = 1; i < foglalasok.Count; i++)
            {
                if (foglalasok[i].ejszakakSzama > foglalasok[maxi].ejszakakSzama)
                    maxi = i;
            }
            return foglalasok[maxi];
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("pitypang.txt");
            int n = Convert.ToInt32(f.ReadLine());

            while (!f.EndOfStream)
            {
                Foglalas sv = new Foglalas(f.ReadLine());
                /*string[] st = f.ReadLine().Split(' ');
                sv.sorszam = Convert.ToInt32(st[0]);
                sv.szobaszam = Convert.ToInt32(st[1]);
                sv.erkezes = Convert.ToInt32(st[2]);
                sv.tavozas = Convert.ToInt32(st[3]);
                sv.vendegekSzama = Convert.ToInt32(st[4]);
                sv.reggeli = st[5] == "1";
                sv.nev = st[6];*/
                foglalasok.Add(sv);
            }

            f.Close();
        }
    }

    struct Honap
    {
        public string honap;
        public int napokSzama, kezdes;

        //konstruktor
        public Honap(string ujhonap, string ujnapok, string kezdes)
        {
            honap = ujhonap;
            napokSzama = Convert.ToInt32(ujnapok);
            this.kezdes = Convert.ToInt32(kezdes);
        }
    }

    struct Foglalas
    {
        // Mezők - tulajdonság
        public int sorszam, szobaszam, erkezes, tavozas, vendegekSzama, ejszakakSzama;
        public bool reggeli;
        public string nev;

        // Konstruktor
        public Foglalas(string sor)
        {
            string[] st = sor.Split(' ');
            sorszam = Convert.ToInt32(st[0]);
            szobaszam = Convert.ToInt32(st[1]);
            erkezes = Convert.ToInt32(st[2]);
            tavozas = Convert.ToInt32(st[3]);
            vendegekSzama = Convert.ToInt32(st[4]);
            reggeli = st[5] == "1";
            nev = st[6];
            ejszakakSzama = tavozas - erkezes;
        }

        // Metódusok - eljrás, fv
        public int FizetendoOsszeg()
        {
            //05.01 - 08.31
            //121 - 243
            int ar = erkezes < 121 ? 9000 : erkezes < 244 ? 10000 : 8000;
            int osszeg = ejszakakSzama * ar +
                (vendegekSzama > 2 ? 2000 * ejszakakSzama : 0) +
                (reggeli ? vendegekSzama * ejszakakSzama * 1100 : 0);
            return osszeg;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", sorszam, szobaszam, erkezes, tavozas, vendegekSzama, reggeli, nev);
        }
    }
}
