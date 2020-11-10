using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Troy
{
    class Typogram
    {
        
            public static string typogram(string text)
            {
                char[] slova = text.ToCharArray();
                string vysledek = "";

                char mezera = ' ';

                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        vysledek += mezera;
                    }

                    vysledek += slova[i] + "\n";
                }

                return vysledek;
            }
        }
    }
}
