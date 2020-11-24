using System;

namespace BeginnerConsoleExamples.Honza
{
    public class Schody
    {


        public static void Down(string text, int length, int offset)
        {
            int iterations = text.Length / length;
            if ((text.Length % length) != 0)
            {
                iterations++;
            }
            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < offset; k++)
                    {
                        Console.Write(' ');
                    }
                }
                int index = i * length;
                string output = "";
                for (int j = 0; j < length; j++)
                {
                    if ((index + j) <= (text.Length - 1))
                    {
                        output += text[index + j];
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}


