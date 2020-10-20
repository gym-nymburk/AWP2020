using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Matej
{
    class Venca
    {
        public static string Pokus()
        {
            return "Ahoj";
        }

        public static string KoktavyVenca(string text, int y, int x)
        {
            string result = "";

            string[] slova = text.Split(' ');

            int i = 0;
            foreach (string word in slova)
            {
                i++;
                if (i == y)
                {
                    for (int j = 0; j < x; j++)
                    {
                        result += word.Substring(0, 1);
                    }

                    result += word.Substring(1, word.Length - 1) + ' ';
                    i = 0;
                }
                else
                {
                    result += word + ' ';
                }
            }

            return result;
        }


        //bonus: opacny venca rekne kazde nté slovo opacne

        public static string OpacnyVenca(string text, int n)
        {
            string result = "";

            string[] slova = text.Split(' ');

            int i = 0;
            int z = 0;
            foreach (string word in slova)
            {
                i++;
                if (i == n)
                {
                    while (z <= word.Length - 1)
                    {

                        result = result + word.Substring(word.Length - 1 - z, 1);
                        z++;
                        i = 0;
                    }
                    result += ' ';
                    z = 0;
                }
                else
                {
                    result += word + ' ';

                }
            }

            return result;
        }
    }
}
