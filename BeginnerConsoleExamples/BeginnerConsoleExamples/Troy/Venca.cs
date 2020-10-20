using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Troy
{
    public class Venca
    {
        
        public static string SprostyVenca(string text, int n)
        {
            string[] slova = text.Split(' ');
            string vysledek = "";

            int i = 0;
            foreach (string word in slova)
            {
                i++;
                if (i == n)
                {
                    vysledek += word + " sakriš ";
                    i = 0;
                }
                else
                {
                    vysledek += word + ' ';
                }
            }

            return vysledek;
        }



        public static string KoktavyVenca(string text, int n, int x)
        {
            string vysledek = "";

            string[] slova = text.Split(' ');

            int i = 0;
            foreach (string word in slova)
            {
                i++;
                if (i == n)
                {
                    for (int j = 0; j < x; j++)
                    {
                        vysledek += word.Substring(0, 1);
                    }

                    vysledek += word.Substring(1, word.Length - 1) + ' ';
                    i = 0;
                }
                else
                {
                    vysledek += word + ' ';
                }
            }

            return vysledek;
        }


        public static string DlouhyVenca(string text, int y)
        {
            string vysledek = "";
            char[] samohlasky = { 'a', 'á', 'e', 'é', 'e', 'i', 'í' , 'y', 'ý', 'o', 'ó' , 'u', 'u', 'ú'};
            string[] slova = text.Split(' ');

            foreach (string word in slova)
            {
                char[] slovo = word.ToCharArray();

                foreach (char pismeno in slovo)
                {
                    if (samohlasky.Contains(pismeno))
                    {
                        for (int k = 0; k < y; k++)
                        {
                            vysledek += pismeno;
                        }
                    }
                    else
                    {
                        vysledek += pismeno;
                    }

                }
                vysledek += " ";
            }

            return vysledek;

        }
    }
}
