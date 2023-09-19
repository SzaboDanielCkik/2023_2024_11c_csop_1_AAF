using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_19_Karakterlanc
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'c';
            Console.WriteLine("betű: " + c);
            Console.WriteLine("betű: " +(char) (c+2));

            string szoveg = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tincidunt tempus pellentesque. Curabitur blandit nunc condimentum, luctus nibh eu, dictum sapien. Proin molestie eu sapien eget mollis. Etiam ex ipsum, auctor sed mollis nec, auctor vitae lectus. Donec placerat justo nec ligula ullamcorper finibus. Vestibulum eu tempus risus. Fusce a mauris viverra, euismod massa aliquet, sagittis nisi. Fusce luctus sapien eu diam lobortis, blandit aliquet dolor vehicula. Cras id massa semper massa feugiat placerat. Donec in dui dapibus, sagittis augue sed, pretium ante. Fusce fermentum pharetra nisl, eu pellentesque sem rhoncus et. Praesent at convallis enim, et luctus odio. Nam ipsum velit, ornare a mauris vel, suscipit rutrum neque. Curabitur rhoncus ipsum ut ipsum maximus fermentum non quis ligula.";
            Console.WriteLine(szoveg);
            Console.WriteLine("Az első karakter: " + szoveg.First() /*szoveg[0]*/);
            Console.WriteLine("A szöveg hossza: " + szoveg.Length);
            Console.WriteLine("Az utolsó karakter: " + /*szoveg.Last()*/ szoveg[szoveg.Length-1]);

            // Hány darab mondat  van a szövegben (ponttal végződik)?

            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == '.')
                    db++;
            }
            Console.WriteLine(db + " darab mondat van.");

            // Van-e a szövegben q-betű?

            int j = 0;
            while (j < szoveg.Length && szoveg[j] != 'q')
                j++;
            if (j < szoveg.Length)
                Console.WriteLine("Van benne q betű");
            else
                Console.WriteLine("Nincs benne q betű");

            Console.WriteLine(c + " ascii kódja: " + Convert.ToInt32(c));

            //28-29 feladat

            Console.ReadLine();
        }
    }
}
