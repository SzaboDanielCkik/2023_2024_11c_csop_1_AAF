using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_04_Szamitogep
{
    class Szamitogep
    {
        //Mezők, adattagok
        double memoria;
        bool bekapcsolva;
        //public static string szin = "kék";


        //public double Memoria { get; set; }
        //public double Memoria
        //{
        //    get
        //    {
        //        return memoria;
        //    }
        //    set {
        //        memoria = value;
        //    }
        //}

        //public double GetMemoria(){return memoria;}
        //public double MemoriaErteke()
        //{
        //    return memoria;
        //}



        //Konstruktorok
        public Szamitogep(double memoria, bool bekapcsolva)
        {
            this.memoria = memoria;
            this.bekapcsolva = bekapcsolva;
            //szin = "zöld";
        }

        public Szamitogep()
        {
            memoria = 1024;
            bekapcsolva = false;
        }

        public void Kapcsol()
        {
            bekapcsolva = !bekapcsolva;
        }

        public bool ProgramMasol(double memoria)
        {
            if (bekapcsolva && this.memoria >= memoria)
            {
                this.memoria -= memoria;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", bekapcsolva ? "Bekapcsolva" : "Kikapcsolva", memoria);
        }


        public static List<Szamitogep> FileSzamitogepek(string utvonal)
        { 
            List<Szamitogep> szamitogepek = new List<Szamitogep>();
            
            StreamReader f = new StreamReader(utvonal);
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split('\t');
                if (st[0] == "-")
                    szamitogepek.Add(new Szamitogep());
                else
                    szamitogepek.Add(new Szamitogep(Convert.ToDouble(st[0]), st[1] == "x"));
                //Console.WriteLine(szamitogepek.Last().ToString());
            }
            f.Close();


            return szamitogepek;
        }


    }
}
