using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Filip
{
    class Venca
    {
        /// <summary>
        /// Koktavy Venca
        /// Venca se v kazdem Ntem slove zakokta, tzn zopakuje prvni slovo Xkrat
        /// </summary>
        /// <param name="text">input pro Vencu</param>
        /// <param name="n">kolikate kazde slovo se Venca zakokta</param>
        /// <param name="x">kolikrat zopakuje Venca prvni pismeno pri zakoktani</param>
        /// <returns>vysledny text</returns>
        public static string KoktavyVenca(string text, int n, int x)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');

            int i = 0;

            foreach (string slovo in slova)
            {
                i++;
                if (i == n)
                {
                    for (int j = 0; j < x - 1; j++)
                    {
                        vysledek += slovo.First();
                    }
                    i = 0;
                }
                vysledek += slovo + " ";
            }
            return vysledek;
        }

        /// <summary>
        /// Roztrzity Venca
        /// Venca kazde nte slovo zapomene
        /// </summary>
        /// <param name="text">input pro Vencu</param>
        /// <param name="n">kolikate kazde slovo Venca vynecha</param>
        /// <returns>vysledny text</returns>
        public static string RoztrzityVenca(string text, int n)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');

            int i = 0;

            foreach (string slovo in slova)
            {
                i++;
                if (i == n) i = 0;
                else vysledek += slovo + " ";
            }
            return vysledek;
        }

        /// <summary>
        /// Nesmely Venca
        /// Venca se pred kazdym Ntym slovem zasekne a rekne "eee"
        /// </summary>
        /// <param name="text">input pro Vencu</param>
        /// <param name="n">kolikate kazde slovo se Venca zasekne</param>
        /// <returns>Vysledny text</returns>
        public static string NesmelyVenca(string text, int n)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');

            int i = 0;

            foreach (string slovo in slova)
            {
                i++;
                if (i == n)
                {
                    vysledek += "eee ";
                    i = 0;
                }
                vysledek += slovo + " ";
            }
            return vysledek;
        }

        /// <summary>
        /// Kricici Venca
        /// Venca kazde nte slovo zakrici (capslock)
        /// </summary>
        /// <param name="text">input pro Vencu</param>
        /// <param name="n">kolikate kazde slovo kricet</param>
        /// <returns>Vysledny text</returns>
        public static string KriciciVenca(string text, int n)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');

            int i = 0;

            foreach (string slovo in slova)
            {
                i++;
                if (i == n)
                {
                    i = 0;
                    vysledek += slovo.ToUpper() + " ";
                }
                else vysledek += slovo + " ";
            }
            return vysledek;
        }

        /// <summary>
        /// Genialni Venca
        /// Prehazuje pismena uvnitr slov viz http://www.zasifruj.cz/
        /// Jedna se o nejextremnejsi pripad, kde nezustane na svem miste zadne vnitrni pismeno
        /// Krom vyjimky viz radek 190, to uz se mi vsak nechce opravovt, vubec je to cele dost priserne, ale vice mene to funguje
        /// </summary>
        /// <param name="text">Venca prehazi pismenka uprostred slov tohoto textu</param>
        /// <returns>vysledny text</returns>
        public static string GenialniVenca(string text)
        {
            string vysledek = "";
            string[] slova = text.Split(' ');

            Random rnd = new Random();

            foreach (string slovo in slova)
            {
                char[] pismena = slovo.ToCharArray();

                //ve slovech se 3 pismeny a mene zustavaji vsechny na svem miste
                if (pismena.Length < 4)
                {
                    vysledek += slovo + " ";
                    continue;
                }

                var pismenaList = pismena.ToList();
                string noveSlovo = "";

                //prvni pismeno musi zustat na svem miste
                noveSlovo += pismena.First();
                string konecSlova = "";

                //posledni pismeno take, ale pokud je posledni char neni pismeno, je treba aby zustalo i predposledni pismeno
                switch (pismena.Last())
                {
                    case ',':
                    case '.':
                    case '?':
                    case '!':
                    case ':':
                    case '-':
                        konecSlova += pismena[pismena.Length - 2];
                        konecSlova += pismena[pismena.Length - 1];
                        pismenaList.RemoveAt(pismenaList.Count - 1); //odstrani posledni charakter z listu pismen pro prehazeni
                        pismenaList.RemoveAt(pismenaList.Count - 1); //odstrani predposledni charakter z listu pismen pro prehazeni (nyni posledni v pismenaList)
                        break;
                    default:
                        konecSlova += pismena[pismena.Length - 1];
                        pismenaList.RemoveAt(pismenaList.Count - 1);
                        break;
                }
                //odstrani prvni charakter z listu pismen pro prehazeni
                pismenaList.RemoveAt(0);

                //dokud jsou jeste nejaka pismena neprehozena
                int citac = 0;
                while (pismenaList.Count > 0)
                {
                    int nahodneCislo = -1;
                    //cilem teto podminky je aby kvuli nahode nebylo pismeno prehozeno na sve puvodni misto
                    do
                    {
                        nahodneCislo = rnd.Next(0, pismenaList.Count);
                        //pokud to vsak vyjde tak, ze by posledni pismeno k prehozeni melo zustat na svem puvodnim miste, neexistuje uz jina moznost, ale jsem linej to predelat
                        if (pismenaList.Count < 2) break;
                    }
                    while (pismenaList[nahodneCislo] == pismena[citac + 1]);

                    noveSlovo += pismenaList[nahodneCislo];
                    //odstrani prave prehozene pismeno z listu pismen pro prehozeni
                    pismenaList.RemoveAt(nahodneCislo);
                    citac++;
                }

                //prida puvodni konec slova do noveho slova
                noveSlovo += konecSlova;

                vysledek += noveSlovo + " ";
            }
            return vysledek;
        }
    }
}

