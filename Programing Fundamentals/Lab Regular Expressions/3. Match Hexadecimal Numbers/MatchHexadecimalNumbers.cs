using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Match_Hexadecimal_Numbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            var numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, regex).Cast<Match>().Select(n => n.Value).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
