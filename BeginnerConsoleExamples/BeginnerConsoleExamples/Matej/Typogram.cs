using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_Matej_Novak_Aws
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Typogram("Nejaky text na ukazku ze mi to funguje"));

            Console.ReadLine();

        }

        private static string Typogram(string text)
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

