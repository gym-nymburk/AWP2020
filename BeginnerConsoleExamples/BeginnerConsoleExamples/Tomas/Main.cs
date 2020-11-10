using System;

namespace BeginnerConsoleExamples.Tomas
{
    public class Main :Runner
    {
        protected override string Title => "Tomas";

        protected override void RunInternal()
        {
           //Console.WriteLine(Venca.Sprosty("Dobré odpoledne všichni přítomní studenti","krucinál",2));
           //Typogram.SikmoDolu("Za chvilku bude zvonit");

            //Soubory.FileList(@"C:\TEMP","*.txt",3);

            Soubory.FileList(@"C:\TEMP",new DateTime(2020,1,1),  "*.txt");
            

        }
    }
}
