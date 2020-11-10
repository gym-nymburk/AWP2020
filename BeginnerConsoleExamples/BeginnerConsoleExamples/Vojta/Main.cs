using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Vojta
{
    public class Main : Runner
    {
        protected override string Title => "Vojta";

        protected override void RunInternal()
        {
            Console.WriteLine("Koktavý Venca");
            Console.WriteLine(Venca.Koktavy("Já nekoktám přece, i když možná trochu", 2, 5));

            Console.WriteLine("Typogram");
            Console.WriteLine(Typogram.Vytvor("Typogram"));
        }
    }
}
