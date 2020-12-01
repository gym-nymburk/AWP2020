using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Ondra
{
    public class Zvire
    {
        public string Jmeno { get; set; }

        public DateTime Narozeni { get; set; }

        public string Plemeno { get; set; }

        public string Pohlavi { get; set; }

        public string Desc => $"{Jmeno}: {Narozeni}, {Plemeno}, {Pohlavi}";

    }
}
