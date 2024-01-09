using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_18_Struktura
{
    struct Szemelygepkocsi
    {
        //Mező, tagjai, jellemzői
        public string marka, rendszam, tulajdonos;
        public int gyartasiEv, HUT, kmAllas; //HUT - hengerűrtartalom

        public string Kiiratas()
        {
            return string.Format("{0}, {1}, {2}, {3} ev, {4} cm3, {5} km", tulajdonos, marka, rendszam, gyartasiEv, HUT, kmAllas);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
                Elem típusok: int, char, bool, string, double
                Összet típusok, adatszerkezet: array, list, 2D_array, list<list> 
                struktura
             */

            Szemelygepkocsi auto1 = new Szemelygepkocsi();
            auto1.tulajdonos = "Kis Gyula";
            auto1.marka = "Ford";
            auto1.kmAllas = 123456;
            auto1.HUT = 1600;
            auto1.gyartasiEv = 2013;
            auto1.rendszam = "abb-658";
            Console.WriteLine(auto1.Kiiratas());

            /*Szemelygepkocsi auto2 = new Szemelygepkocsi();
            auto2.tulajdonos = "Nagy Rozália";
            auto2.marka = "Honda";
            auto2.kmAllas = 4567;
            auto2.HUT = 1000;
            auto2.gyartasiEv = 2018;
            auto2.rendszam = "tzu-234";
            Console.WriteLine(auto2.tulajdonos+" "+auto2.marka+"...");*/

            int a = 2;
            int b = a;
            a = 4;
            Console.WriteLine(a + " " + b);

            Szemelygepkocsi auto3 = auto1;
            Console.WriteLine(auto3.Kiiratas());
            auto3.tulajdonos = "Suticsky Béla";
            Console.WriteLine(auto3.Kiiratas());
            Console.WriteLine(auto1.Kiiratas());


            string sz1 = "Gyuri Suzuki 1300 2002";
            string sz2 = "Kati Merci 1500 2007";
            string sz3 = "Pali BMW 2200 2005";

            /*string[] st1 = sz1.Split(' '); 
            string[] st2 = sz2.Split(' '); 
            string[] st3 = sz3.Split(' ');

            Szemelygepkocsi auto4 = new Szemelygepkocsi();
            auto4.tulajdonos = st1[0];
            auto4.marka = st1[1];
            auto4.HUT = Convert.ToInt32(st1[2]);
            auto4.gyartasiEv = Convert.ToInt32(st1[3]);

            Szemelygepkocsi auto5 = new Szemelygepkocsi();
            auto5.tulajdonos = st2[0];
            auto5.marka = st2[1];
            auto5.HUT = Convert.ToInt32(st2[2]);
            auto5.gyartasiEv = Convert.ToInt32(st2[3]);*/


            /*Szemelygepkocsi auto4 = Atalakit(sz1);
            Szemelygepkocsi auto5 = Atalakit(sz2);
            Szemelygepkocsi auto6 = Atalakit(sz3);
            Console.WriteLine(auto4.Kiiratas());*/

            List<Szemelygepkocsi> autok = new List<Szemelygepkocsi>();
            autok.Add(Atalakit(sz1));
            autok.Add(Atalakit(sz2));
            autok.Add(Atalakit(sz3));
            Console.WriteLine(autok[0].Kiiratas());

            /* Feltöltesz plusz 4 adatot a listába (szöveg segítségével)
             * FV: A legidősebb auto tulajdonsa!
             * Fv: A HUT átlagát!*/

            Console.ReadLine();
        }

        static Szemelygepkocsi Atalakit(string sz)
        {
            string[] st = sz.Split(' ');
            Szemelygepkocsi auto = new Szemelygepkocsi();
            auto.tulajdonos = st[0];
            auto.marka = st[1];
            auto.HUT = Convert.ToInt32(st[2]);
            auto.gyartasiEv = Convert.ToInt32(st[3]);
            return auto;
        }
    }


}
