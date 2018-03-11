using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._A_Miner_Task
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();
            var line = Console.ReadLine();
            var count = 1;
            var current = "";

            while (line != "stop")
            {
                if (count % 2 != 0)
                {
                    if (!dict.ContainsKey(line))
                    {
                        dict.Add(line, 0L);
                    }

                    current = line;
                }
                else
                {
                    var num = dict[current];
                    num += long.Parse(line);
                    dict[current] = num;
                }

                count++;
                line = Console.ReadLine();
            }

            var lines = dict.Select(kvp => kvp.Key + " -> " + kvp.Value);
            Console.WriteLine(string.Join(Environment.NewLine, lines));
        }
    }
}
