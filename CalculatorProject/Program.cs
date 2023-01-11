using System;

namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Hello World!");

            #if DEBUG
                Console.WriteLine("Debug version");
            #else
                Console.WriteLine("Release version");
            #endif

            if (i == 1)
                Console.WriteLine("Hello World!");
        }
    }
}
