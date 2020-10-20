using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerConsoleExamples
{
    public abstract class Runner
    {
        protected abstract string Title { get; }

        protected abstract void RunInternal(); 


        public void Run()
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"{Title}:");
            Console.WriteLine(new string('=', 30));
            RunInternal();
            Console.WriteLine();
        }



        
    }
}
