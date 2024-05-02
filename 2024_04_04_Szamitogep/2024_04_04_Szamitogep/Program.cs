using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_04_Szamitogep
{
    class Program
    {
        static List<Szamitogep> szamitogepek = new List<Szamitogep>();

        static void Main(string[] args)
        {
            Feladat1();
            Fajlbeolvasas();

            Console.ReadLine();
        }

        private static void Fajlbeolvasas()
        {
            szamitogepek = Szamitogep.FileSzamitogepek("Szamitogep.txt");
        }

        private static void Feladat1()
        {
            Szamitogep szAlap = new Szamitogep();
            Szamitogep sz1 = new Szamitogep(2000, false);

            //Console.WriteLine( Szamitogep.szin );


            Console.WriteLine(szAlap.ToString());
            Console.WriteLine(sz1.ToString());


            szAlap.Kapcsol();
            if (szAlap.ProgramMasol(800)) Console.WriteLine("A másolás sikeres volt");
            else
                Console.WriteLine("A másolás sikertelen volt");
            if (szAlap.ProgramMasol(400)) Console.WriteLine("A másolás sikeres volt");
            else
                Console.WriteLine("A másolás sikertelen volt");
            Console.WriteLine(szAlap.ToString());


            if (sz1.ProgramMasol(1)) Console.WriteLine("A másolás sikeres volt");
            else
                Console.WriteLine("A másolás sikertelen volt");
            Console.WriteLine(sz1.ToString());
        }
    }

}
