using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples
{
    public class Tomas :Runner
    {
        protected override string Title => "Tomas";

        protected override void RunInternal()
        {
            Console.WriteLine("Pokus");
        }
    }
}
