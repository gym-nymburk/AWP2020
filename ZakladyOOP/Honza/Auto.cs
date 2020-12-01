using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Honza
{
    public class Automobil
    {
        public string Značka { get; set; }

        public string Barva { get; set; }

        public int MaximalniRychlost { get; set; }

        public string Model { get; set; }


        public string Desc => $"{Značka}: {Model}, {Barva}, {MaximalniRychlost}";

    }
}
