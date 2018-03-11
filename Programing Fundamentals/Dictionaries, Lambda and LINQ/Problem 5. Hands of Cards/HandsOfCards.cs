using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Hands_of_Cards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, HashSet<string>>();
            var nameResult = new Dictionary<string, long>();
            var line = Console.ReadLine();
            
            while (line != "JOKER")
            {
                var split = line.Split(new char[] { ':'}, StringSplitOptions.RemoveEmptyEntries);
                var name = split[0];
                var cards = split[1].Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                if (!dict.ContainsKey(name))
                {
                    var set = new HashSet<string>(cards);
                    dict.Add(name, set);
                    nameResult.Add(name, 0L);
                }
                else
                {
                    var hand = dict[name];
                    foreach (var card in cards)
                    {
                        hand.Add(card);
                    }

                    dict[name] = hand;
                }

                line = Console.ReadLine();
            }
            
            foreach (var item in dict.Keys)
            {
                var set = dict[item];
                foreach (var card in set)
                {
                    var powerStr = card.Substring(0, card.Length - 1);
                    var typeStr = card[card.Length - 1].ToString();
                    var type = 0L;
                    var power = 0L;

                    switch (powerStr)
                    {
                        case "J":
                            power = 11;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "A":
                            power = 14;
                            break;
                        default:
                            power = long.Parse(powerStr);
                            break;
                    }

                    switch (typeStr)
                    {
                        case "S":
                            type = 4;
                            break;
                        case "H":
                            type = 3;
                            break;
                        case "D":
                            type = 2;
                            break;
                        case "C":
                            type = 1;
                            break;
                    }

                    var res = nameResult[item];
                    res += power * type;
                    nameResult[item] = res;
                }
            }
            
            var lines = nameResult.Select(kv => kv.Key + ": " + kv.Value);
            Console.WriteLine(string.Join(Environment.NewLine, lines));

        }
    }
}
