using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Ondra
{
    public class Stairs
    {
        public static void Down(string text, int len, int offset)
        {
            if (len > text.Length)
            {
                Console.WriteLine("Požadovaná délka je delší než text");
                return;
            }

            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;

                if (i % len == 0)
                {
                    string mezera = new string(' ', count * (len - offset));
                    string slovo = text.Substring(i, len);
                    Console.WriteLine(mezera + slovo);
                    count++;
                }
                
            }
        }
    }
}
