using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Logs_Aggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var usersDuration = new SortedDictionary<string, long>();
            var usersIps = new Dictionary<string, HashSet<string>>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var ip = input[0];
                var user = input[1];
                var duration = long.Parse(input[2]);

                if (!usersDuration.ContainsKey(user))
                {
                    usersDuration.Add(user, duration);
                    var ips = new HashSet<string>();
                    ips.Add(ip);
                    usersIps.Add(user, ips);
                }
                else
                {
                    var time = usersDuration[user];
                    time += duration;
                    usersDuration[user] = time;

                    var userIp = usersIps[user];
                    userIp.Add(ip);
                    usersIps[user] = userIp;
                }
            }

            foreach (var user in usersDuration.Keys)
            {
                var ips = usersIps[user].OrderBy(i => i);
                Console.WriteLine($"{user}: {usersDuration[user]} [{string.Join(", ", ips)}]"); 
            }
        }
    }
}
