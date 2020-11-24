using System;
using System.Diagnostics;

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

            //Soubory.FileList(@"C:\TEMP",new DateTime(2020,1,1),  "*.txt");

            //Stairs.Down("abcdefghijklmn",4,2);

            //Pokus();
           
            Osoby();
        }


        void Pokus()
        {
            Pokus pokus1 = new Pokus("Titulek A");
            pokus1.Hello("a");

            Pokus pokus2 = new Pokus("Titulek B");
            pokus2.Hello("b");
        }

        void Osoby()
        {
            Osoba[] osoby = new Osoba[5];

            //starší způsob inicializace objektů
            osoby[0] = new Osoba();
            osoby[0].Jmeno = "Jan";
            osoby[0].Prijmeni = "Novák";
            osoby[0].DatumNarozeni = new DateTime(2001, 05, 12);

            //novější způsob (object initializer)
            osoby[1] = new Osoba
            {
                Jmeno = "Karel",
                Prijmeni = "Novotný",
                DatumNarozeni = new DateTime(2002, 04, 12)
            };

            osoby[2] = new Osoba
            {
                Jmeno = "Karel",
                Prijmeni = "Hájek",
                DatumNarozeni = new DateTime(2002, 04, 12)
            };

            //cyklus přes všechny osoby
            foreach (Osoba osoba in osoby)
            {
                if (osoba != null)   //pozor, pro osoba == null by volání osoba.CeleJmeno skončilo na NullReferenceException
                {
                    Console.WriteLine(osoba.CeleJmeno);
                }
            }
        }
    }
}
