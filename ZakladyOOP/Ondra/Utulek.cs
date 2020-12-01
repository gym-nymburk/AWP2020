using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Ondra
{
    public class Utulek
    {
        public Utulek()
        {
            Zvirata = new[]
            {
                new Zvire
                {
                    Jméno = "Adam",
                    Narozeni = "1.1.2020",
                    Plemeno = "Kolie"
                    Pohlavi = "pes"
                }
                new Zvire
                {
                    Jméno = "Alena",
                    Narozeni = "1.2.2020",
                    Plemeno = "Border kolie"
                    Pohlavi = "fena"
                }
            }
        }


        private Zvirata[] Zvire;


        public void Seznam()
        {
            foreach (Zvire in Zvirata)
            {
                Console.WriteLine(Zvire.Desc);
            }
        }

    }
}
