using System;

namespace BeginnerConsoleExamples.Filip
{
    public class Main : Runner
    {
        protected override string Title => "Filip";

        protected override void RunInternal()
        {
            //Console.WriteLine(Venca.KoktavyVenca("Ahoj jak se  mas ja se mam skvele xd looool", 3, 3));
            //Console.WriteLine(Venca.RoztrzityVenca("Ahoj jak se mas ja se mam skvele xd looool", 2));
            //Console.WriteLine(Venca.NesmelyVenca("Ahoj jak se mas ja se mam skvele xd looool", 3));
            //Console.WriteLine(Venca.KriciciVenca("Ahój jak se máš xd já se mám skvěle jak ty lmao motorka", 4));
            //Console.WriteLine(Venca.GenialniVenca("Ahoj jak se mas xd ja se mam skvele jak ty lmao motorka"));

            Console.WriteLine("Zadejte text ze ktereho chcete udelat umeni:");
            Typogram.Umeni(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
