using System;
using System.Text.RegularExpressions;

namespace Lab_Regular_Expressions
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            var matches = Regex.Matches(names, regex);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
