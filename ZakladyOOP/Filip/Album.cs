using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Filip
{
    class Album
    {
        public Album()
        {
            pisne = new[]
            {
                new Pisen
                {
                    Nazev = "Bílá orchidej",
                    Zanr = "dechovka",
                    Tempo = 70,
                    Delka = new TimeSpan(0, 4, 32)
                },
                new Pisen
                {
                    Nazev = "Černá orchidej",
                    Zanr = "electro",
                    Tempo = 120,
                    Delka = new TimeSpan(0, 2, 48)
                },
                new Pisen
                {
                    Nazev = "Studna",
                    Zanr = "pop",
                    Tempo = 95,
                    Delka = new TimeSpan(0, 3, 55)
                }
            };
        }


        private Pisen[] pisne;


        public void Tracklist()
        {
            int PocetPisni = pisne.Length;
            Console.WriteLine($"V Albu jsou {PocetPisni} pisne:");
            TimeSpan CelkovaDelka = new TimeSpan(0, 0, 0);
            foreach (Pisen pisen in pisne)
            {
                Console.WriteLine(pisen.Popis);
                CelkovaDelka += pisen.Delka;
            }
            string CelkovaDelkaText = CelkovaDelka.ToString();
            Console.WriteLine($"Celkova delka alba je: {CelkovaDelkaText}.");

        }
    }
}
