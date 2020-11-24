using System;

namespace BeginnerConsoleExamples.Tomas
{
    public class Osoba
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public string Telefon { get; set; }

        public DateTime DatumNarozeni { get; set; }

        public string CeleJmeno => Jmeno + " " + Prijmeni;
    }
}