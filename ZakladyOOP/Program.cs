﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakladyOOP.Tomas;

namespace ZakladyOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna();
            knihovna.Seznam();

            Ondra.Utulek utulek = new Ondra.Utulek();
            utulek.Seznam();

            Console.ReadLine();
        }
    }
}
