using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var regexCount = @"([STARstar])";
            //var regexStar = @"@([A-Za-z]+)";
            //var regexPopulation = @":([0-9]+)";
            //var regexAttack = @"!(A|D)!";
            //var regexSoldierCount = @"->([0-9]+)";
            var regex = @"[^@\-:!>]*@(?<star>[A-Za-z]+)[^@\-:!>]*:(?<population>[0-9]+)[^@\-:!>]*!(?<attack>A|D)![^@\-:!>]*->(?<soldierCount>[0-9]+)";
            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                var message = Console.ReadLine();
                var count = 0;
                if (Regex.IsMatch(message, regexCount))
                {
                    count = Regex.Matches(message, regexCount).Count;
                }

                var builder = new StringBuilder();
                for (int j = 0; j < message.Length; j++)
                {
                    builder.Append((char)(message[j] - count));
                }

                var decrypted = builder.ToString();
                if (Regex.IsMatch(decrypted, regex))
                {
                    var star = Regex.Match(decrypted, regex).Groups["star"].Value;
                    var population = Regex.Match(decrypted, regex).Groups["population"].Value;
                    var attack = Regex.Match(decrypted, regex).Groups["attack"].Value;
                    var soldierCount = Regex.Match(decrypted, regex).Groups["soldierCount"].Value;

                    switch (attack)
                    {
                        case "A":
                            attackedPlanets.Add(star);
                            break;
                        case "D":
                            destroyedPlanets.Add(star);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
            if (attackedPlanets.Count() > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, attackedPlanets.OrderBy(p => p).Select(p => $"-> {p}")));

            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            if (destroyedPlanets.Count() > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, destroyedPlanets.OrderBy(p => p).Select(p => $"-> {p}")));
            }

        }
    }
}
