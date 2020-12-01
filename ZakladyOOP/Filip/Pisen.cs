using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Filip
{
    class Pisen
    {
        public string Nazev { get; set; }

        public string Zanr { get; set; }

        public int Tempo { get; set; }

        public TimeSpan Delka { get; set; }

        public string Popis => Nazev + " - " + Zanr + ", Tempo: " + Tempo + " BPM, Delka: " + Delka.ToString();
    }
}
