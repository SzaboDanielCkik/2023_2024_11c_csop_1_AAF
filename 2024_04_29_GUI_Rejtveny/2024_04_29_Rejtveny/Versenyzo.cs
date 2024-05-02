using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_29_Rejtveny
{
    class Versenyzo
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

        public int HajokSzama()
        {
            int db = 0;
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    if (tabla[i, j] == 11) db++;
                }
            }
            return db;
        }

        public bool VaneErintkezes()
        {
            int i = 0;
            bool vane = false;
            while (i < tabla.GetLength(0) && !vane)
            {
                int j = 0;
                while (j < tabla.GetLength(1) && (tabla[i, j] == 0 || CsakNullaSzomszed(i, j)))
                    j++;
                if (j < tabla.GetLength(1))
                    vane = true;
                else
                    i++;
            }
            return vane;
        }

        public bool CsakNullaSzomszed(int sor, int oszlop)
        {
            int i = -1;
            bool joe = true;
            while (i < 2 && joe)
            {
                int j = -1;
                while (j < 2 &&
                    ((sor + i == -1 || oszlop + j == -1 ||
                    sor + i >= tabla.GetLength(0) || oszlop + j >= tabla.GetLength(1) ||
                    tabla[sor + i, oszlop + j] == 0) || (i == 0 && j == 0)))
                    j++;
                if (j < 2)
                    joe = false;
                else
                    i++;
            }
            return joe;
        }
    }
}
