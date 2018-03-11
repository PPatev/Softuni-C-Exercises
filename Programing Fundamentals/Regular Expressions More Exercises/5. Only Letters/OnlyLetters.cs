using System;
using System.Text.RegularExpressions;

namespace _5._Only_Letters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var evaluator = new MatchEvaluator(m => {
                var index = input.IndexOf(m.Value);
                if (index + m.Value.Length >= input.Length)
                {
                    return m.Value;
                }

                var letter = input[index + m.Value.Length];

                return letter.ToString();
            });
            var replace = Regex.Replace(input, @"\d+", evaluator);
            Console.WriteLine(replace);
        }
    }
}
