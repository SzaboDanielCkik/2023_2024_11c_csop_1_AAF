using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_19_Valasztas
{
    class Program
    {
        static List<Kepviselo> kepviselok = new List<Kepviselo>();
        static string[] partok = new string[] { "GYEP", "Gyümölcsevők Pártja", "HEP", "Húsevők Pártja", "TISZ", "Tejivók Szövetsége", "ZEP", "Zöldségevők Pártja","-","Független jelölt" };
        static int osszes = 12345;
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();


            Console.ReadLine();
        }

        private static void Feladat7()
        {
            StreamWriter f = new StreamWriter("kepviselok.txt");
            Console.WriteLine("7. feladat");
            List<Kepviselo> lista = KeruletMaximumKivalasztas();
            //List<Kepviselo> legjobbak = LegjobbKepviselok(lista);
            for (int i = 0; i < lista.Count; i++)
            {
                f.WriteLine(lista[i].valasztoKerulet + " " + lista[i].nev + " " + 
                    (lista[i].part == "-" ? "független" : lista[i].part));
            }
            f.Close();
        }


        static List<Kepviselo> LegjobbKepviselok(List<Kepviselo> kigyujtott)
        {
            List<Kepviselo> lista = new List<Kepviselo>();
            int maxe = 0;
            for (int i = 0; i < kigyujtott.Count; i++)
            {
                if (maxe < kigyujtott[i].szavazatokSzama)
                {
                    lista.Clear();
                    maxe = kigyujtott[i].szavazatokSzama;
                    lista.Add(kigyujtott[i]);
                }
                else if(maxe == kigyujtott[i].szavazatokSzama)
                    lista.Add(kigyujtott[i]);
            }
            return lista;
        }

        static List<Kepviselo> KeruletMaximumKivalasztas()
        {
            List<Kepviselo> lista = new List<Kepviselo>();

            for (int i = 1; i < 9; i++)
            {
                int index = MaximumSzavazatKeresesIndex(i);
                lista.Add(kepviselok[index]);
            }
            return lista;
        }

        static int MaximumSzavazatKeresesIndex(int kerulet)
        {
            int maxi = 0;
            for (int i = 0; i < kepviselok.Count; i++)
            {
                if (kepviselok[i].valasztoKerulet == kerulet &&
                    kepviselok[i].szavazatokSzama > kepviselok[maxi].szavazatokSzama)
                    maxi = i;
            }
            return maxi;
        }


        private static void Feladat6()
        {
            Console.WriteLine("6. feladat");
            List<int> indexek = MaxIndexek();
            for (int i = 0; i < indexek.Count; i++)
            {
                Console.WriteLine("{0} -{1}", kepviselok[indexek[i]].nev,/*kepviselok[indexek[i]].PartHosszan(),*/kepviselok[indexek[i]].part);
            }
        }

        static List<int> MaxIndexek()
        {
            int maxe = 0;
            List<int> indexek = new List<int>();
            for (int i = 0; i < kepviselok.Count; i++)
            {
                if (maxe < kepviselok[i].szavazatokSzama)
                {
                    indexek.Clear();
                    maxe = kepviselok[i].szavazatokSzama;
                    indexek.Add(i);
                }
                else if (maxe == kepviselok[i].szavazatokSzama)
                    indexek.Add(i);
            }
            return indexek;
        }

        private static void Feladat5()
        {
            Console.WriteLine("5. feladat");
            for (int i = 0; i < partok.Length; i+=2)
            {
                double darab = PartokSzavazatai(partok[i]);
                Console.WriteLine("{0} = {1}%",partok[i+1],
                    Math.Round(darab/osszes*100,2));
            }
            Console.WriteLine();
        }

        private static double PartokSzavazatai(string part)
        {
            int db = 0;
            for (int i = 0; i < kepviselok.Count; i++)
                if (kepviselok[i].part == part) db+=kepviselok[i].szavazatokSzama;
            return db;
        }

        private static void Feladat4()
        {
            Console.WriteLine("4. Feladat");

            double osszeg = 0;
            for (int i = 0; i < kepviselok.Count; i++)
                osszeg += kepviselok[i].szavazatokSzama;

            Console.WriteLine("A választáson {0} állampolgár, a jogosultak {1}%-a vett részt.", osszeg, Math.Round(osszeg / osszes *100, 2));
            Console.WriteLine();
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat");
            Console.Write("Adja meg a képviselő teljes nevét: ");
            string nev = Console.ReadLine();
            int db = HanyszavazatotKapottNev(nev);
            if (db != -1)
                Console.WriteLine("{0} - {1} db szavazatot kapott.", nev, db);
            else
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban");
            Console.WriteLine();

        }

        private static int HanyszavazatotKapottNev(string nev)
        {
            int i = 0;
            while (i < kepviselok.Count && kepviselok[i].nev != nev)
                i++;
            return i < kepviselok.Count ? kepviselok[i].szavazatokSzama : -1;
        }

        static void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.WriteLine("Képviselők száma: {0} fő",kepviselok.Count);
            Console.WriteLine();
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("szavazatok.txt");

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                Kepviselo sv = new Kepviselo();
                sv.valasztoKerulet = Convert.ToInt32(st[0]);
                sv.szavazatokSzama = Convert.ToInt32(st[1]);
                sv.nev = st[2] + " " + st[3];
                sv.part = st[4];
                kepviselok.Add(sv);
            }
            f.Close();
        }
    }

    struct Kepviselo
    {
        public string nev, part;
        public int valasztoKerulet, szavazatokSzama;

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", valasztoKerulet,szavazatokSzama,nev,part);
        }

        public string PartHosszan()
        {
            switch (part)
            {
                case "GYEP": return "Gyümölcsevők Pártja";
                case "HEP": return "Húsevők Pártja";
                case "TISZ": return "Tejivók Szövetsége";
                case "ZEP": return "Zöldségevők Pártja";
                case "-": return "Független jelölt";
            }
            return "";
        }
    }
}
