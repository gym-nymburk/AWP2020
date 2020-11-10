using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Matej
{
    class Stairs
    {
        public static string Schody(string text, int z, int v)
        {
            string result = "";
            int i = 0;
            int x = 0;
            int y = 0;
            foreach (char c in text)
            {
                while (x < i)
                {
                    result = result + " ";
                    x++;
                }
                while (y < z)
                {
                    result = result + c;
                    y++;
                }
                y = 0;
                x = 0;
                i++;
                i = i + v;
                result = result + "\n";
            }

            return result;
        }
    }

}
