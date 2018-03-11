using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5._Match_Numbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbersStrings = Console.ReadLine();
            var numbers = Regex.Matches(numbersStrings, regex).Cast<Match>().Select(n => n.Value).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
