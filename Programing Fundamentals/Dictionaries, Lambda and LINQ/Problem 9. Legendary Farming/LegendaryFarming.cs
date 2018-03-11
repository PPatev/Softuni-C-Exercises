using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._Legendary_Farming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, long>();
            items.Add("shards", 0L);
            items.Add("fragments", 0L);
            items.Add("motes", 0L);

            var junk = new SortedDictionary<string, long>();

            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                for (int i = 0; i < line.Length; i += 2)
                {
                    var quantity = long.Parse(line[i]);
                    var item = line[i + 1].ToLower();

                    if (CheckIfJunk(item))
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, quantity);
                        }
                        else
                        {
                            var quant = junk[item];
                            quant += quantity;
                            junk[item] = quant;
                        }
                    }
                    else
                    {
                        if (!items.ContainsKey(item))
                        {
                            if (quantity >= 250)
                            {
                                items.Add(item, quantity - 250);
                                Print(items, junk, item);
                                return;
                            }

                            items.Add(item, quantity);
                        }
                        else
                        {
                            var quant = items[item];
                            if (quant + quantity >= 250)
                            {
                                items[item] = (quantity + quant - 250);
                                Print(items, junk, item);
                                return;
                            }

                            items[item] = (quantity + quant);
                        }
                    }
                }

            }
        }

        private static void Print(Dictionary<string, long> items, SortedDictionary<string, long> junk, string obtainedItem)
        {
            var obtained = CheckObtained(obtainedItem);
            Console.WriteLine($"{obtained} obtained!");
            var sorted = items.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string CheckObtained(string obtainedItem)
        {
            var result = "";
            switch (obtainedItem)
            {
                case "shards":
                    result = "Shadowmourne";
                    break;
                case "fragments":
                    result = "Valanyr";
                    break;
                case "motes":
                    result = "Dragonwrath";
                    break;
            }

            return result;
        }

        private static bool CheckIfJunk(string item)
        {
            switch (item)
            {
                case "shards":
                    return false;
                case "fragments":
                    return false;
                case "motes":
                    return false;
            }

            return true;
        }
    }
}
