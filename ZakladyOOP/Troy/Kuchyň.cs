using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Troy
{
    class Kuchyň
    {
        public Kuchyň()
        {
            nádobí = new[]
            {
                new Věc
                {
                    Nazev = "Vidlička",
                    Použití = "konzumace jídla"
                },
                new Věc
                {
                    Nazev = "Nůž",
                    Použití = "konzumace jídla"
                },
                new Věc
                {
                    Nazev = "Lžíce",
                    Použití = "konzumace jídla"
                },
                new Věc
                {
                    Nazev = "Pánvička",
                    Použití = "smažení"
                },
                new Věc
                {
                    Nazev = "Hrnec",
                    Použití = "vaření"
                },
                new Věc
                {
                    Nazev = "Trouba",
                    Použití = "pečení"
                },
                new Věc
                {
                    Nazev = "Mikrovlnka",
                    Použití = "ohřívání jídla"
                },
            };
        }

        private Věc[] nádobí;

        public void Seznam()
        {
            foreach (Věc věc in nádobí)
            {
                Console.WriteLine(věc.Desc);
            }
        }
    }
}
