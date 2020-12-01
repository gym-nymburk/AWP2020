using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Vojta
{
    public class Lide
    {
        public Lide()
        {
            lide = new[]
            {
                new Clovek
                {
                    jmeno = "Vojtěch",
                    prijmeni = "Novotný",
                    vek = 18
                },
                new Clovek
                {
                    jmeno = "Pepa",
                    prijmeni = "Pepík",
                    vek = 18
                },
                 new Clovek
                {
                    jmeno = "Ondřej",
                    prijmeni = "Žežule",
                    vek = 18
                }
            };
        }

        private Clovek[] lide;


        public void VypisLidi()
        {
            foreach (Clovek clovek in lide)
            {
                Console.WriteLine(clovek.Predstaveni);
            }
        }
    }
}
