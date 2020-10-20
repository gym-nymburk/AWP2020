using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Ondra
{
    public class Typogramy
    {
        public static void Sikmodolu(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                
                string mezery = new string(' ', i);
                string pismeno = text.Substring(i, 1);
                Console.WriteLine(mezery + pismeno);

            }
        }
    }
}
