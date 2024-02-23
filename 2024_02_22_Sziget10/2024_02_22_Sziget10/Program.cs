using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_22_Sziget10
{
    class Program
    {
        static List<int> t = new List<int>();
        static void Main(string[] args)
        {
            t= Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32).ToList();
            int startI = TengerJobbra(0);
            int endI = TengerBalra(t.Count);
            int index = MaxTavIndex(startI, endI);
            Console.WriteLine(2+TengerBalra(index)+ " " + TengerJobbra(index));
            Console.ReadLine();
        }

        static int TengerJobbra(int kezdet)
        {
            int i = kezdet;
            while (t[i] != 0) i++;
            return i;
        }

        static int TengerBalra(int vege)
        {
            int i = vege-1;
            while (t[i] != 0) i--;
            return i;
        }

        static int MaxTavIndex(int startI, int endI)
        {
            int maxi = startI;
            for (int i = startI; i < endI; i++)
            {
                if (t[i] != 0 && t[i+1] != 0 &&  Math.Abs(t[i] - t[i + 1]) > Math.Abs(t[maxi] - t[maxi + 1]))
                    maxi = i;
            }
            return maxi;
        }
    }
}

/*
12
3 0 1 1 5 4 0 2 5 1 0 2
*/