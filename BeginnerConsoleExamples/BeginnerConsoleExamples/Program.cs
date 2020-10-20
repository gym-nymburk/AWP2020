using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeginnerConsoleExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Tomas.Main T = new Tomas.Main();
            T.Run();

            Ondra.Main O = new Ondra.Main();
            O.Run();


            Console.ReadLine();

        }
    }
}
