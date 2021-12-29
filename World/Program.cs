using System;

namespace World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Map m = new Map(50);
            m.takt();
            Console.ReadKey();
        }
    }
}
