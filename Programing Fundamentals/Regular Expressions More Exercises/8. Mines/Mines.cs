using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _8._Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            var mineField = Console.ReadLine();
            var mineRegex = @"(<(.{2})>)";
            
            var evaluator = new MatchEvaluator(m => {



                return new string('_', m.Value.Length);
            });

            if (Regex.IsMatch(mineField, mineRegex))
            {
                var minesStrength = Regex.Matches(mineField, mineRegex).Cast<Match>().Select(m =>
                {
                    var mine = m.Groups[2].Value;
                    return Math.Abs(mine[0] - mine[1]);
                }).ToArray();
                var mines = Regex.Matches(mineField, mineRegex).Cast<Match>().Select(m => m.Groups[1].Value).ToArray();

                var replaced = mineField;

                for (int i = 0; i < mines.Length; i++)
                {
                    var mine = mines[i];
                    var strength = minesStrength[i];
                    var mineExplode = @"(.{0," + strength + "}" + mine + ".{0," + strength + "})";
                    replaced = Regex.Replace(replaced, mineExplode, evaluator);
                }

                Console.WriteLine(replaced);
            }
        }
    }
}
