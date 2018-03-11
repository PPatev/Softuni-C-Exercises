using System;
using System.Collections.Generic;

namespace Problem_11._Dragon_Army
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            var typeDragonsStats = new Dictionary<string, SortedDictionary<string, long[]>>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var type = input[0];
                var name = input[1];
                var stats = ConvertStats(input);
                var damage = stats[0];
                var health = stats[1];
                var armor = stats[2];

                if (!typeDragonsStats.ContainsKey(type))
                {
                    var dragon = new SortedDictionary<string, long[]>();
                    dragon.Add(name, stats);
                    typeDragonsStats.Add(type, dragon);
                }
                else
                {
                    var dragons = typeDragonsStats[type];
                    if (!dragons.ContainsKey(name))
                    {
                        dragons.Add(name, stats);
                    }
                    else
                    {
                        dragons[name] = stats;
                    }

                    typeDragonsStats[type] = dragons;
                }
            }

            foreach (var type in typeDragonsStats.Keys)
            {
                var dragons = typeDragonsStats[type];
                var count = (double)dragons.Count;
                var damage = 0L;
                var health = 0L;
                var armor = 0L;
                var str = new List<string>();
                foreach (var dragon in dragons.Keys)
                {
                    var stats = dragons[dragon];
                    damage += stats[0];
                    health += stats[1];
                    armor += stats[2];
                    str.Add($"-{dragon} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");
                }

                var damageAvg = Math.Round(damage / count, 2);
                var healthAvg = Math.Round(health / count, 2);
                var armorAvg = Math.Round(armor / count, 2);
                Console.WriteLine($"{type}::({damageAvg:F2}/{healthAvg:F2}/{armorAvg:F2})");
                Console.WriteLine(string.Join(Environment.NewLine, str));
            }
        }

        private static long[] ConvertStats(string[] input)
        {
            var stats = new long[3];
            for (int i = 2; i < input.Length; i++)
            {
                if (input[i] == "null")
                {
                    switch (i)
                    {
                        case 2:
                            stats[i - 2] = 45L;
                            break;
                        case 3:
                            stats[i - 2] = 250L;
                            break;
                        case 4:
                            stats[i - 2] = 10L;
                            break;
                    }
                }
                else
                {
                    stats[i - 2] = long.Parse(input[i]);
                }

            }

            return stats;
        }
    }
}
