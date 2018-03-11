using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_10._Srbsko_Unleashed
{
    class SrbskoUnleashed
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, long>>();
            var regex = new Regex(@"(.*?)\s{1}@(.*?)\s{1}(\d+)\s{1}(\d+)");

            var line = Console.ReadLine();
            while (line != "End")
            {
                var matches = regex.Match(line);
                if (matches.Success)
                {
                    var singer = matches.Groups[1].ToString();
                    var venue = matches.Groups[2].ToString();
                    var price = long.Parse(matches.Groups[3].ToString());
                    var tickets = long.Parse(matches.Groups[4].ToString());

                    if (!venues.ContainsKey(venue))
                    {
                        var singers = new Dictionary<string, long>();
                        singers.Add(singer, price * tickets);
                        venues.Add(venue, singers);
                    }
                    else
                    {
                        var singers = venues[venue];
                        if (!singers.ContainsKey(singer))
                        {
                            singers.Add(singer, price * tickets);
                            
                        }
                        else
                        {
                            var money = singers[singer];
                            money += price * tickets;
                            singers[singer] = money;
                        }

                        venues[venue] = singers;
                    }

                }

                line = Console.ReadLine();
            }

            foreach (var venue in venues.Keys)
            {
                Console.WriteLine(venue);
                var singers = venues[venue].OrderByDescending(kvp => kvp.Value);
                foreach (var singer in singers)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
