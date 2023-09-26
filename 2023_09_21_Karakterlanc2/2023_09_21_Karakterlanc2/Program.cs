using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_21_Karakterlanc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // HF 14-20.
            // Adott egy szöveg. A felhasználó megadja, hogy melyik betűket szeretné lecserélni melyik betűre.
            //Írasd ki a módosított szöveget!

            string sz = "kalapács";
            char mit = 'a'; // Convert.ToChar(Console.ReadLine());
            char mire = 'e';
            string ki = "";
            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i] == mit)
                    ki += mire;
                else
                    ki += sz[i];
            }
            Console.WriteLine(ki);
            Console.ReadLine();
        }
    }
}
