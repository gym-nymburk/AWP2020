using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Filip
{
    public class Stairs
    {
        /// <summary>
        /// Result for Down2("aaaaaaaaaa", 3,3):
        /// aaa
        ///   a
        ///   aaa
        ///     a
        ///     a
        /// </summary>
        /// <param name="len"></param>
        /// <param name="offset"></param>
        public static void Down2(string text, int width, int height)
        {
            int numOfLetters = text.Length;
            int counter = 0;
            int odsazeni = 0;
            string output = "";
            while (counter < numOfLetters)
            {

                output += new string(' ', Math.Max(((odsazeni * (width - 1))), 0));
                for (int i = 0; i < width; i++)
                {
                    if (counter + 1 > numOfLetters)
                        goto END;
                    
                    output += text.Substring(counter, 1);
                    counter++;
                }
                output += "\n";
                odsazeni++;
                   
                for (int i = 0; i < height - 2; i++)
                {
                    if (counter + 1 > numOfLetters)
                        goto END;
                    output += new string(' ', Math.Max(((odsazeni * (width - 1))), 0));
                    output += text.Substring(counter, 1) + "\n";
                    counter++;
                }
            }
            END:
            Console.WriteLine(output);
        }
    }
}
