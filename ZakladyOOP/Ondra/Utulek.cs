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
                    Jmeno = "Adam",
                    Narozeni = new DateTime(2020, 1, 1),
                    Plemeno = "Kolie",
                    Pohlavi = "pes"
                },
                new Zvire
                {
                    Jmeno = "Alena",
                    Narozeni = new DateTime(2020, 2, 1),
                    Plemeno = "Border kolie",
                    Pohlavi = "fena"
                }
            };
        }


        private Zvire[] Zvirata;

        public void Seznam()
        {
            foreach (Zvire zvire in Zvirata)
            {
                Console.WriteLine(zvire.Desc);
            }
        }

    }
}
