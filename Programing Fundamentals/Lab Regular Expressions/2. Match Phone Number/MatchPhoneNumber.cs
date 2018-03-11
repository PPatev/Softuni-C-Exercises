using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var regex = @"[ ]*\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, regex);
            var matchedPhones = matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
