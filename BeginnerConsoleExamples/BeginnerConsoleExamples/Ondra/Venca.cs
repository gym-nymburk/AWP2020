using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Ondra
{
    public class Venca
    {
        public static string KoktavyVenca(string text, int n, int x)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');
            int i = 0;
            foreach (string slovo in slova)
            {
                i++;
                if (i == n)
                {
                    i = 0;
                    vysledek += new String(slovo[0], x - 1) + slovo + ' ';
                }
                else
                {
                    vysledek += slovo + ' ';
                }
            }
            return vysledek;
        }
    }
}
