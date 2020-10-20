using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Ondra
{
    public class Main : Runner
    {
        protected override string Title => "Ondra";

        protected override void RunInternal()
        {
            Console.WriteLine(Venca.Pokus());
        }
    }
}
