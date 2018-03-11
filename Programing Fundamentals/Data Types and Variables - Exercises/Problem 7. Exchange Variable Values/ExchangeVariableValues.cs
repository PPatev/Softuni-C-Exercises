using System;

namespace Problem_7._Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int c = a;
            a = b;
            b = c;
            
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
