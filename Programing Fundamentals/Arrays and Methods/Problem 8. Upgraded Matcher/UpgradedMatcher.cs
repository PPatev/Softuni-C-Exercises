using System;
using System.Linq;

namespace Problem_8._Upgraded_Matcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Trim().Split(' ');
            var quantities = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Trim().Split(' ').Select(decimal.Parse).ToArray();

            var line = Console.ReadLine();

            while (line != "done")
            {
                var order = line.Trim().Split(' ');
                var product = order[0];
                var quantity = long.Parse(order[1]);
                var index = Array.IndexOf(products, product);
                if (index >= quantities.Length)
                {
                    if (quantity == 0)
                    {
                        var cost = quantity * prices[index];
                        Console.WriteLine($"{product} x {quantity} costs {cost}");
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {product}");
                    }
                }
                else
                {
                    var quantityAvailable = quantities[index];
                    if (quantityAvailable < quantity)
                    {
                        Console.WriteLine($"We do not have enough {product}");
                    }
                    else
                    {
                        quantities[index] -= quantity;
                        var cost = quantity * prices[index];
                        Console.WriteLine($"{product} x {quantity} costs {cost:F2}");
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}
