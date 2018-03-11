using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions_Exercises
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var regex = @"\s([A-Za-z0-9]+[\.\-\w]*\w+@[A-Za-z0-9][\.\-\w]+\.\w+)";
            var text = Console.ReadLine();

            var emails = Regex.Matches(text, regex).Cast<Match>().Select(m => m.Groups[1].Value).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, emails));
        }
    }
}
