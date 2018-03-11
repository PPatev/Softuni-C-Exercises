using System;
using System.Linq;

namespace Problem_7._Inventory_Matcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Trim().Split(' ');
            var quantities = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToArray();

            var line = Console.ReadLine();

            while (line != "done")
            {
                var index = Array.IndexOf(products, line);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

                line = Console.ReadLine();
            }
        }
    }
}
