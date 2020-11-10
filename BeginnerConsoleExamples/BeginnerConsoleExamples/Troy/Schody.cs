using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Troy
{
    class Schody
    {
        /// <summary>
        /// Result for Down("aaaaaaaaaaaaaaaaaaaaaa", 5,2):
        /// aaaaa
        ///    aaaaa
        ///       aaaaa
        ///          aaaaa
        ///             aa
        /// </summary>
        /// <param name="len"></param>
        /// <param name="offset"></param>
        public static void Down(string text, int len, int offset)
        {
            
            char[] pismena = text.ToCharArray();
            string vysledek = "";
            int radek = 0;
            char mezera = ' ';
            for (int k = 0; k < text.Length + 1;)
            {
                for (int i = 0; i < len; i++)
                {
                    if (k >= pismena.Length) goto KONEC;
                    vysledek += pismena[k];
                    k++;
                }
                radek++;
                vysledek += "\n";
                for (int j = 0; j < (len - offset) * radek; j++)
                {
                    vysledek += mezera;
                }
            }
            KONEC:
            Console.WriteLine(vysledek);

        }
    }
    
}
