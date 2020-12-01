using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Troy
{
    class Věc
    {
        public string Nazev { get; set; }

        public string Použití { get; set; }

        public string Desc => $"{Nazev}: {Použití}";
    }
}
