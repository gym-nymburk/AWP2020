﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples.Matej
{
    public class Main : Runner
    {
        protected override string Title => "Matej";

        protected override void RunInternal()
        {
            Console.WriteLine(Venca.Pokus());
        }
    }
}
