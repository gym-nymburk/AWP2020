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

            Vojta.Main V = new Vojta.Main();
            V.Run();

            Filip.Main F = new Filip.Main();
            F.Run();

            Console.ReadLine();

        }
    }
}
