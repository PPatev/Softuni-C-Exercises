using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5._Key_Replacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var keyStr = Console.ReadLine();
            var regexKeys = @"^(?<start>[A-Za-z]+)(\||<|\\).*?(\||<|\\)(?<end>[A-Za-z]+)$";
            var start = Regex.Match(keyStr, regexKeys).Groups["start"].Value;
            var end = Regex.Match(keyStr, regexKeys).Groups["end"].Value;

            var text = Console.ReadLine();
            var regex = @"" + start + @"(.*?)" + end;

            if (!Regex.IsMatch(text, regex))
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                var matched = Regex.Matches(text, regex).Cast<Match>().Select(m => m.Groups[1].Value).ToArray();

                if (string.Join("", matched).Equals(""))
                {
                    Console.WriteLine("Empty result");
                }
                else
                {
                    Console.WriteLine(string.Join("", matched));
                }
            }
        }
    }
}
