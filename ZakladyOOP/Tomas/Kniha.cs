using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Tomas
{
    public class Kniha
    {
        public string Nazev { get; set; }

        public int RokVydani { get; set; }

        public string Autor { get; set; }


        public string Desc => $"{Autor}: {Nazev}, {RokVydani}";

    }
}
