using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_13_Gyakorlas
{
    class Program
    {
        static string szoveg = "";
        static void Main(string[] args)
        {
            SzovegBekerese();
            Console.WriteLine(KisbetusseAlakitas(szoveg));
            Console.WriteLine(NagybetusseAlakitas(szoveg));
            Console.WriteLine(SzovegReszlet(szoveg, 0, 3));
            Console.WriteLine(Kiskapitalis(szoveg));
            Console.WriteLine(SzavakMegforditasa(szoveg));
            Console.WriteLine(SzavakMegforditasa2(szoveg));
            Console.ReadLine();
        }

        static string SzavakMegforditasa2(string szoveg)
        {
            string ujszoveg = "";
            string sv = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] != ' ')
                    sv = szoveg[i] + sv;
                else
                {
                    ujszoveg += sv + " ";
                    sv = "";
                }
            }
            ujszoveg += sv;
            return ujszoveg;
        }

        static string SzavakMegforditasa(string szoveg)
        {
            string ujszoveg = "";

            string[] szavak = SzavakKigyujt(szoveg);
            for (int i = 0; i < szavak.Length; i++)
            {
                ujszoveg += SzoMegfordit(szavak[i])+" ";
            }
            return ujszoveg;
        }

        static string SzoMegfordit(string szo)
        {
            string ujszo = "";
            for (int i = 0; i < szo.Length; i++)
                ujszo = szo[i] + ujszo;
            return ujszo;
        }

        static string[] SzavakKigyujt(string szoveg)
        {
            int szavakSzama = SzokozSzamolas(szoveg) + 1;
            string[] szavak = new string[szavakSzama];
            string szo = "";
            int k = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] != ' ')
                    szo += szoveg[i];
                else
                {
                    szavak[k] = szo;
                    k++;
                    szo = "";
                }
            }
            szavak[k] = szo;
            return szavak;
        }

        static int SzokozSzamolas(string szoveg)
        {
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
                if (szoveg[i] == ' ') db++;
            return db;
        }

        static string Kiskapitalis(string szoveg)
        {
            string ujSzoveg = "";
            if (!Nagybetue(szoveg[0]))
                ujSzoveg += (char)(szoveg[0] - 32);
            for (int i = 1; i < szoveg.Length; i++)
            {
                if (szoveg[i] == ' ')
                {
                    if (Nagybetue(szoveg[i + 1]))
                        ujSzoveg += " " + szoveg[i + 1];
                    else
                        ujSzoveg += " " + (char)(szoveg[i + 1] - 32);
                    i++;
                }
                else
                    ujSzoveg += szoveg[i];                   
            }
            return ujSzoveg;
        }

        static string SzovegReszlet(string sz, int kezdo, int db)
        {
            string ujsz = "";
            for (int i = kezdo; i < kezdo + db; i++)
                ujsz += sz[i];
            return ujsz;
        }

        static string NagybetusseAlakitas(string sz)
        {
            string ujszoveg = "";
            for (int i = 0; i < sz.Length; i++)
            {
                if (Nagybetue(sz[i]))
                    ujszoveg += sz[i];
                else
                    ujszoveg += (char)(sz[i] - 32);
            }
            return ujszoveg;
        }

        static string KisbetusseAlakitas(string sz)
        {
            string ujszoveg = "";
            for (int i = 0; i < sz.Length; i++)
            {
                if (Nagybetue(sz[i]))
                    ujszoveg += (char)(sz[i] + 32);
                else
                    ujszoveg += sz[i];
            }
            return ujszoveg;
        }

        static bool Nagybetue(char c)
        {
            return c >= 65 && c <= 90;
        }

        static void SzovegBekerese()
        {
            do
            {
                Console.Write("Adjon meg egy szöveget: ");
                szoveg = Console.ReadLine();
            } while (szoveg.Length < 1 || szoveg.Length > 100);
        }
    }
}
