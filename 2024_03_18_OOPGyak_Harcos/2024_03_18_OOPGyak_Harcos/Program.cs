using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_18_OOPGyak_Harcos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Generálj ki 8 Harcost Kódnévvel és véletlen HP, DMG-vel!
             * Kódnév: 5 db véletlen karakter, kis és nagybetűs
             * Hp: [1000,5000] között 00-ra végződjön.
             * DMG: [50,200] 0-ra végződjön.
             * Kiesős harc! Ki a győztes?*/

            Harcos h1 = new Harcos("Vasember", 1000,120);
            Harcos h2 = new Harcos("Hulk", 500, 160);

            while (!h1.Harcol(h2)) ;
            if(h1.Eletero< h2.Eletero)
                Console.WriteLine(h2.Nev+" nyert.");
            else
                Console.WriteLine(h1.Nev + " nyert.");

            Console.ReadLine();

        }
    }

    class Harcos
    {
        //Mezők
        private int eletero, harciero;
        private string nev;

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
        }

        public bool Harcol(Harcos masikHarcos)
        {
            eletero -= masikHarcos.harciero;
            masikHarcos.eletero -= harciero;
            return eletero < 0 || masikHarcos.eletero < 0;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} HP: {1} DMG: {2}", Nev, eletero, harciero);
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
