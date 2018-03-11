using System;
using System.Collections.Generic;

namespace Problem_2._Vapor_Store
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var moneySpent = 0.0;

            var line = Console.ReadLine();

            while (line != "Game Time")
            {
                var price = 0.0;

                switch (line)
                {
                    case "OutFall 4":
                        price = 39.99; break;
                    case "CS: OG":
                        price = 15.99; break;
                    case "Zplinter Zell":
                        price = 19.99; break;
                    case "Honored 2":
                        price = 59.99; break;
                    case "RoverWatch":
                        price = 29.99; break;
                    case "RoverWatch Origins Edition":
                        price = 39.99; break;
                    
                }

                if (price == 0.0)
                {
                    Console.WriteLine("Not Found");
                    line = Console.ReadLine();
                    continue;
                }

                if (balance - price >= 0)
                {
                    balance -= price;
                    moneySpent += price;
                    Console.WriteLine($"Bought {line}");
                } else if (balance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${balance:F2}");
        }
    }
}
