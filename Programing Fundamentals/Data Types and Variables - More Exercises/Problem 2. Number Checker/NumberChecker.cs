using System;

namespace Problem_2._Number_Checker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            if (number.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
