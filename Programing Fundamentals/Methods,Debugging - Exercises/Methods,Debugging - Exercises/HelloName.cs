using System;

namespace Methods_Debugging___Exercises
{
    class HelloName
    {
        static void Main(string[] args)
        {
            Print(Console.ReadLine());
        }

        static void Print(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
