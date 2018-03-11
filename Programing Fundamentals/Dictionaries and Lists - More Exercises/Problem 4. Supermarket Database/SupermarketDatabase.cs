using System;
using System.Collections.Generic;

namespace Problem_4._Supermarket_Database
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            var productsPrices = new Dictionary<string, double>();
            var productsQuantities = new Dictionary<string, long>();
            var grandTotal = 0.0;

            var line = Console.ReadLine();
            while (line != "stocked")
            {
                var input = line.Split(' ');
                var productName = input[0];
                var productPrice = double.Parse(input[1]);
                var productQuantity = long.Parse(input[2]);

                if (!productsPrices.ContainsKey(productName))
                {
                    productsPrices.Add(productName, productPrice);
                    productsQuantities.Add(productName, productQuantity);
                }
                else
                {
                    productsPrices[productName] = productPrice;
                    var quantity = productsQuantities[productName];
                    quantity += productQuantity;
                    productsQuantities[productName] = quantity;
                }

                line = Console.ReadLine();
            }

            foreach (var product in productsPrices.Keys)
            {
                var price = productsPrices[product];
                var quantity = productsQuantities[product];
                var total = price * quantity;
                grandTotal += total;
                Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${total:F2}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
