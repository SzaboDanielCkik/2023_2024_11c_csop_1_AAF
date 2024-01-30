using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_29_rejtveny
{
    class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static int[,] feladvany = new int[10, 10];

        static void Main(string[] args)
        {
            Feladat_1_2();
            Fajlbeolvasas();
            FajbolFeladvany();
            Feladat3();

            Console.ReadLine();
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat");
            int db = 0;
            for (int i = 0; i < versenyzok.Count; i++)
            {
                if (versenyzok[i].Osszehasonlit(feladvany))
                    db++;
                else
                    Console.WriteLine(versenyzok[i].nev);
            }
            if (db == versenyzok.Count) 
                Console.WriteLine("Mindegyik megoldás erre a heti feladványra érkezett.");
            
        }

        private static bool Osszehasonlit(int[,] tabla, int[,] feladvany)
        {
            bool vane = true;
            int i = 0;
            int j = 0;
            while (i < tabla.GetLength(0) && vane)
            {
                j = 0;
                while (j < tabla.GetLength(1) && (feladvany[i, j] == 0 || feladvany[i, j] == tabla[i, j]))
                    j++;
                if (j < tabla.GetLength(1)) vane = false;
                else i++;
            }
            return vane;


            /*for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    if (feladvany[i, j] > 0 && feladvany[i, j] != tabla[i, j])
                        return false;
                }
            }
            return true;*/
        }

        private static void FajbolFeladvany()
        {
            StreamReader f = new StreamReader("feladvany.txt");
            feladvany = TablaKiolvas(f);
            f.Close();
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("megoldas.txt");
            //int n = Convert.ToInt32(f.ReadLine());
            f.ReadLine();
            while (!f.EndOfStream)
            {
                Versenyzo sv = new Versenyzo(f.ReadLine(), TablaKiolvas(f));
                /*sv.nev = f.ReadLine();
                sv.tabla = TablaKiolvas(f);*/
                versenyzok.Add(sv);
            }
            f.Close();
        }

        static int[,] TablaKiolvas(StreamReader f)
        {
            int[,] sm = new int[10, 10];
            for (int i = 0; i < sm.GetLength(0); i++)
            {
                string[] st = f.ReadLine().Split(' ');
                //int[] st1 = Array.ConvertAll(f.ReadLine().Split(' '), Convert.ToInt32);
                for (int j = 0; j < sm.GetLength(1); j++)
                {
                    sm[i, j] = Convert.ToInt32(st[j]);
                }
            }
            return sm;
        }

        static void Feladat_1_2()
        {
            Console.WriteLine("Adja meg a világító torony sorát: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a világítótorony oszlopát: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a világítótorony értékét: ");
            int ertek = Convert.ToInt32(Console.ReadLine());

            Console.Write(ertek>3 ? "Nehéz torony\n" : "");
            Feladat2(sor-1, oszlop-1);
        }

        private static void Feladat2(int sorIndex, int oszlopIndex)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if((i != 0 || j != 0) && sorIndex+i>-1 && oszlopIndex+j>-1 && sorIndex+i<10 && oszlopIndex+j<10)
                        Console.WriteLine(sorIndex+i+1+","+(oszlopIndex+j+1));
                }
            }
        }
    }

    struct Versenyzo
    {
        public string nev;
        public int[,] tabla;

        // konstruktor
        public Versenyzo(string ujnev, int[,] ujtabla)
        {
            nev = ujnev;
            tabla = ujtabla;
        }

        // metódus
        public bool Osszehasonlit(int[,] feladvany)
        {
            bool vane = true;
            int i = 0;
            int j = 0;
            while (i < tabla.GetLength(0) && vane)
            {
                j = 0;
                while (j < tabla.GetLength(1) && (feladvany[i, j] == 0 || feladvany[i, j] == tabla[i, j]))
                    j++;
                if (j < tabla.GetLength(1)) vane = false;
                else i++;
            }
            return vane;
        }
    }
}
