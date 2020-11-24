using System;
using System.Diagnostics;

namespace BeginnerConsoleExamples.Tomas
{
    public class Pokus
    {
        public Pokus(string title)
        {
            Title = title;
        }
        
        
        public void Hello(string text)
        {
            Console.WriteLine($"{Title}: {text}");
        }


        public string Title { get; }
    }
}