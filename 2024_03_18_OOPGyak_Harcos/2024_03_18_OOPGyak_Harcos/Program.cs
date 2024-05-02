using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_18_OOPGyak_Harcos
{
    class Program
    {
        static List<Harcos> harcosok = new List<Harcos>();
        static Random r = new Random();
        static void Main(string[] args)
        {
            /* Generálj ki 8 Harcost Kódnévvel és véletlen HP, DMG-vel!
             * Kódnév: 5 db véletlen karakter, kis és nagybetűs
             * Hp: [1000,5000] között 00-ra végződjön.
             * DMG: [50,200] 0-ra végződjön.
             * Kiesős harc! Ki a győztes?*/

            ListaFeltoltes();
            //ListaKiirat(harcosok);

            //Tournament(harcosok);
            //Tournament2(harcosok);
            Tournament3(harcosok);

            /*Harcos h1 = new Harcos("Vasember", 1000,120);
            Harcos h2 = new Harcos("Hulk", 500, 160);

            while (!h1.Harcol(h2)) ;
            if(h1.Eletero< h2.Eletero)
                Console.WriteLine(h2.Nev+" nyert.");
            else
                Console.WriteLine(h1.Nev + " nyert.");*/

            Console.ReadLine();

        }

        private static void Tournament3(List<Harcos> lista)
        {
            List<Harcos> nyertesek = new List<Harcos>();
            nyertesek.AddRange(lista);

            Console.WriteLine(lista[0].ToString());
            //Harcos[] tomb = lista.ToArray();

            nyertesek[0].Eletero = 123456;
            Console.WriteLine(lista[0].ToString());
            Console.WriteLine(nyertesek[0].ToString());



        }

        private static void Tournament2(List<Harcos> lista)
        {
            ListaKiirat(lista);
            if (lista.Count > 1)
            {
                List<Harcos> nyertesek = new List<Harcos>();
                for (int i = 0; i < lista.Count; i += 2)
                {
                    while (!lista[i].Harcol(lista[i + 1])) ;
                    if (lista[i].Eletero > lista[i + 1].Eletero) nyertesek.Add(lista[i]);
                    else nyertesek.Add(lista[i + 1]);
                    nyertesek.Last().Eletero = nyertesek.Last().eredetiEleter;
                }
                Tournament2(nyertesek);
            }
        }

        private static void Tournament(List<Harcos> lista)
        {
            ListaKiirat(lista);
            if (lista.Count > 1)
            {
                List<Harcos> nyertesek = new List<Harcos>();
                for (int i = 0; i < lista.Count; i+=2)
                {
                    while (!lista[i].Harcol(lista[i + 1])) ;
                    if (lista[i].Eletero > lista[i + 1].Eletero) nyertesek.Add(lista[i]);
                    else nyertesek.Add(lista[i+1]);
                }
                Tournament(nyertesek);
            }
        }

        private static void ListaKiirat(List<Harcos> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            Console.WriteLine();
        }

        static void ListaFeltoltes()
        {
            for (int i = 0; i < 8; i++)
            {
                harcosok.Add(new Harcos(NevGeneral(), r.Next(10, 50) * 100, r.Next(5, 20) * 10));
            }
        }
        static string NevGeneral()
        {
            string nev = "";
            for (int i = 0; i < 5; i++)
            {
                nev += r.Next(2) == 0 ? "" + (char)r.Next(97, 123) : "" + (char)r.Next(65, 91);
            }
            return nev;
        }
    }


    class Harcos
    {
        //Mezők
        private int eletero, harciero;
        private string nev;
        public int eredetiEleter;

        public int Eletero { 
            get { return eletero; }
            set { eletero = value; } 
        }
        public string Nev {
            get { return nev; }
            set { nev = value; }
        }
        public int Harciero
        {
            get { return harciero; }
            set { harciero = value; }
        }

        //Konstruktor
        public Harcos(string nev, int eletero, int harciero)
        {
            this.eletero = eletero;
            this.harciero = harciero;
            this.nev = nev;
            eredetiEleter = eletero;
        }

        public bool Harcol(Harcos masikHarcos)
        {
            eletero -= masikHarcos.harciero;
            masikHarcos.eletero -= harciero;
            return eletero < 0 || masikHarcos.eletero < 0;
        }

        public override string ToString()
        {
            return string.Format("{0} HP: {1} DMG: {2}", Nev, eletero, harciero);
        }

        //public int GetEletero()
        //{
        //    return eletero;
        //}

        //public string GetNev()
        //{
        //    return nev;
        //}
    }
}
