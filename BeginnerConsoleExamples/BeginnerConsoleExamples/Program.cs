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
            Filip.Main f = new Filip.Main();
            f.Run();

            Honza.Main h = new Honza.Main();
            h.Run();

            Ondra.Main o = new Ondra.Main();
            o.Run();

            Tomas.Main t = new Tomas.Main();
            t.Run();

            Vojta.Main v = new Vojta.Main();
            v.Run();


            Console.ReadLine();

        }
    }
}
