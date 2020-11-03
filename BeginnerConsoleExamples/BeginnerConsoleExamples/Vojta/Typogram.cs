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
            //string[] splittedText = text.Split(" ").ToString();
            string[] typogramArr = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                string gaps = new string(' ', i);
                string letterWithGaps = $"{gaps} {text[i]} \n";
                typogramArr[i] = letterWithGaps;
            }
            string typogram = string.Join("", typogramArr);
            return typogram;
        }
    }
}
