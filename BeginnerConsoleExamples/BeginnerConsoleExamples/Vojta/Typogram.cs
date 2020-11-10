using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Vojta
{
    class Typogram
    {
        public static string Vytvor(string text)
        {
            string[] rows = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                string gaps = new string(' ', i);
                string letterWithGaps = $"{gaps} {text[i]}";
                rows[i] = letterWithGaps;
            }

            return string.Join("\n", rows); 
        }
    }
}
