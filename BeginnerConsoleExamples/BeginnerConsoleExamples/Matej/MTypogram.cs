using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Matej
{
    class MTypogram
    {
        public static string Typogram(string text)
        {
            string result = "";
            int i = 0;
            int x = 0;
            foreach (char c in text)
            {
                while (x < i)
                {
                    result = result + " ";
                    x++;
                }
                result = result + c + "\n";
                x = 0;
                i++;
            }

            return result;
        }

    }
}