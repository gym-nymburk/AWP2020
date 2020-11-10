using System;

public class Schody
{
	public Schody()
	{
        void Down(string text, int len, int offset)
        {
            int iterations = text.length() / len;
            if ((text.length % length) != 0)
            {
                iterations++;
            }
            for (int i = 0, i < iterations, i++)
            {
                for (int j = 0, j < i, j++)
                {
                    for (int k = 0, k < offset, k++)
                    {
                        Console.Write(' ');
                    }
                }
                int index = i * len;
                string out = "";
                for (int j = 0, j < len)
                {
                    if ((index + j) <= (text.length() - 1)
                    {
                out += text[index + j];
                    }
                }
                Console.WriteLine(out);
            }
        }
    }
}
