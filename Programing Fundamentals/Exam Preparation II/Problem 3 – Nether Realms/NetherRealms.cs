using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3___Nether_Realms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var healthRegex = @"[^0-9+\-*\/.]";
            var damageRegex = @"([0-9.]+)";
            var specials = @"(\*|\/){1}";

            var demons = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).OrderBy(x => x);
            foreach (var demon in demons)
            {
                long health = 0;
                if (Regex.IsMatch(demon, healthRegex))
                {
                    health = Regex.Matches(demon, healthRegex).Cast<Match>().Select(m => (int)m.Value[0]).Sum();
                }

                double damage = 0;
                if (Regex.IsMatch(demon, damageRegex))
                {
                    damage = Regex.Matches(demon, damageRegex).Cast<Match>().Select(m =>
                    {
                        var index = m.Index;
                        if (index - 1 >= 0)
                        {
                            if (demon[index - 1] == '-')
                            {
                                return double.Parse(m.Value) * (-1);
                            }
                        }

                        return double.Parse(m.Value);
                    }).Sum();
                }

                if (Regex.IsMatch(demon, specials))
                {
                    foreach (var m in Regex.Matches(demon, specials).Cast<Match>())
                    {
                        var value = m.Value;
                        switch (value)
                        {
                            case "*":
                                damage *= 2;
                                break;
                            case "/":
                                damage /= 2;
                                break;
                        }
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
