using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Filip
{
    public class Main : Runner
    {
        protected override string Title => "Filip";

        protected override void RunInternal()
        {
            Console.WriteLine(Filip.Pokus());
        }
    }
}
