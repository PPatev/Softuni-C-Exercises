using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6._Email_Statistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            var regex = @"^([A-Za-z]{5,})@([a-z]{3,}(\.com|\.bg|\.org))$";
            var lines = int.Parse(Console.ReadLine());
            var emails = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();

                if (Regex.IsMatch(input, regex))
                {
                    var user = Regex.Match(input, regex).Groups[1].Value;
                    var domain = Regex.Match(input, regex).Groups[2].Value;

                    if (!emails.ContainsKey(domain))
                    {
                        var users = new HashSet<string>();
                        users.Add(user);
                        emails.Add(domain, users);
                    }
                    else
                    {
                        var users = emails[domain];
                        users.Add(user);
                        emails[domain] = users;
                    }
                }
            }

            var sorted = emails.OrderByDescending(kvp => kvp.Value.Count());
            foreach (var email in sorted)   
            {
                var domain = email.Key;
                var users = email.Value.ToArray();
                Console.WriteLine($"{domain}:");
                Console.WriteLine(string.Join(Environment.NewLine, users.Select(u => $"### {u}")));
            }
        }
    }
}
