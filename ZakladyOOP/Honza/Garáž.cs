using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Honza
{
    public class Garáž
    {
        public Garáž()
        {
            automobily = new[]
            {
                new Automobil
                {
                    Značka = "Fiat",
                    Model = "500",
                    Barva= "Bílá"
                    MaximalniRychlost = 85
                }
                new Automobil
                {
                    Značka = "Ford",
                    Model = "S-Max",
                    Barva = "Černá"
                    MaximalniRychlost = 187
                }
                new Automobil
                {
                    Značka = "Škoda"
                    Model = "Octavia RS"
                    Barva = "Stříbrná"
                    MaximalniRychlost = 240
                }
                new Automobil
                {
                    Značka = "Fiat"
                    Model = "Multipla"
                    Barva = "Hnědá"
                    MaximalniRychlost = 170
                }
            };
        }


        private Automobil[] automobily;


        public void Seznam()
        {
            foreach (Automobil automobil in automobily)
            {
                Debug.WriteLine(automobil.Desc);
            }
        }

    }
}
