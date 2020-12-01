using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakladyOOP.Vojta
{
    class Clovek
    {
        public string jmeno { get; set; }

        public string prijmeni { get; set; }

        public int vek { get; set; }

        public string Predstaveni => $"Ahoj jmenuji se {jmeno} {prijmeni} a je mi {vek} let";
    }
}
