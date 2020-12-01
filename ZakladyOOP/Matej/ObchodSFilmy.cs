using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Matej
{
    public class ObchodSFilmy
    {
        public ObchodSFilmy()
        {
            filmy = new[]
            {
                new Film
                {
                    Reziser = "Christopher Nolan",
                    Nazev = "Temny rytíř",
                    RokVydani = 2008
                },
                new Film
                {
                    Reziser = "James Cameron",
                    Nazev = "Avatar",
                    RokVydani = 2009
                },
                 new Film
                {
                    Reziser = "Steven Spielberg",
                    Nazev = "Ready player one",
                    RokVydani = 2018
                }
            };
        }


        private Film[] filmy;


        public void Seznam()
        {
            foreach (Film film in filmy)
            {
                Console.WriteLine(film.Desc);
            }
        }

    }
}
