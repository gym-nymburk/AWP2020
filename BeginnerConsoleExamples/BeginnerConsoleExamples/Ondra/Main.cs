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
            Typogramy.Sikmodolu("ahoj jak se mas");
            //Console.WriteLine(Venca.KoktavyVenca("Konecne koktej Venco, uz me seres, nedelam si srandu, znicim te.", 2, 3));
            Console.ReadLine();
        }
    }
    
}
