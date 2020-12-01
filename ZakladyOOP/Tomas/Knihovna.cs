using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Tomas
{
    public class Knihovna
    {
        public Knihovna()
        {
            knihy = new[]
            {
                new Kniha
                {
                    Autor = "Karel Čapek",
                    Nazev = "RUR",
                    RokVydani=1920
                }, 
                new Kniha
                {
                    Autor = "Karel Čapek",
                    Nazev = "Dášeňka čili život štěněte",
                    RokVydani = 1933
                }
            };
        }


        private Kniha[] knihy;


        public void Seznam()
        {
            foreach (Kniha kniha in knihy)
            {
                Debug.WriteLine(kniha.Desc);
            }
        }

    }
}
