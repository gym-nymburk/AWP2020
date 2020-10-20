using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Vojta
{
    class Venca
    {
        public static string Koktavy(string text, int n, int x)
        {
            string[] splittedText = text.Split();
            for (int i = 0; i < splittedText.Length; i++)
            {
                if ((i + 1) % n == 0)
                {
                    string firstLetter = splittedText[i][0].ToString();
                    int e = 0;
                    string stammeredWord = splittedText[i];
                    while (e < x)
                    {
                        stammeredWord = stammeredWord.Insert(0, $"{firstLetter} ");
                        e++;
                    }
                    splittedText[i] = stammeredWord;
                }
            }
            string stammeredText = string.Join(" ", splittedText);
            return stammeredText;
        }
    }
}
