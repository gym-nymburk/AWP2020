using System;

namespace BeginnerConsoleExamples.Troy
{
    public class Main :Runner
    {
        protected override string Title => "Troy";

        protected override void RunInternal()
        {
            //Console.WriteLine(Typogram.typogram("ahoj jak se mas ja se mam dobre"));
            //Console.WriteLine(Venca.SprostyVenca("Ahoj jak se mate vsichni", 2));
            //Console.WriteLine(Venca.KoktavyVenca("Ahoj jak se mate vsichni", 3, 5));
            //Console.WriteLine(Venca.DlouhyVenca("Ahoj jak se mate vsichni", 4));
            Schody.Down("abcdefghijklmnopqrstuv", 5, 2);
            Console.ReadKey();
        }
    }
}
