using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Matej
{
    public class Main : Runner
    {
        protected override string Title => "Matej";

        protected override void RunInternal()
        {
            //Console.WriteLine(Venca.Pokus());
            //Console.WriteLine(Venca.KoktavyVenca("Nejaky text na ukazku ze mi to funguje", 3, 3));
            //Console.WriteLine(Venca.OpacnyVenca("Nejaky text na ukazku ze mi to funguje", 2));
            //Console.ReadLine();
            // Console.WriteLine(MTypogram.Typogram("Nejaky text na ukazku ze mi to funguje"));
            Console.WriteLine(Stairs.Schody("aaaaaaaaaaaaaaaaaaa", 5, 2));
            Console.ReadLine();
        }
    }
}
