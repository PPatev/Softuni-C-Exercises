using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._User_Logs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var userIp = new SortedDictionary<string, Dictionary<string, long>>();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var info = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = info[0].Substring(3);
                var username = info[2].Substring(5);

                if (!userIp.ContainsKey(username))
                {
                    var ips = new Dictionary<string, long>();
                    ips.Add(ip, 1);
                    userIp.Add(username, ips);
                }
                else
                {
                    var ips = userIp[username];
                    if (!ips.ContainsKey(ip))
                    {
                        ips.Add(ip, 1);
                    }
                    else
                    {
                        var count = ips[ip];
                        count++;
                        ips[ip] = count;
                    }

                    userIp[username] = ips;
                }

                line = Console.ReadLine();
            }

            var lines = userIp.Select(kv => kv.Key + ":" + Environment.NewLine + string.Join(", ", kv.Value.Select(kvp => kvp.Key + " => " + kvp.Value)) + ".");
            Console.WriteLine(string.Join(Environment.NewLine, lines));
        }
    }
}
