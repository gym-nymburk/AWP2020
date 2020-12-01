using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Matej
{
    public class Film
    {
        public string Nazev { get; set; }

        public int RokVydani { get; set; }

        public string Reziser { get; set; }


        public string Desc => $"{Reziser}: {Nazev}, {RokVydani}";

    }
}
