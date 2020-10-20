using System;

namespace BeginnerConsoleExamples.Tomas
{
    public class Main :Runner
    {
        protected override string Title => "Tomas";

        protected override void RunInternal()
        {
           Console.WriteLine(Venca.Sprosty("Dobré odpoledne všichni přítomní studenti","krucinál",2));
        }
    }
}
