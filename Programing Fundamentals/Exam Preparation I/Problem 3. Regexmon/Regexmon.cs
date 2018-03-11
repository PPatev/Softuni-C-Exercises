using System;
using System.Text.RegularExpressions;

namespace Problem_3._Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var didimonRegex = new Regex("([^A-Za-z-]+)");
            var bojomonRegex = new Regex("([A-Za-z]+-[A-Za-z]+)");
            var count = 0;

            while (true)
            {
                if (count % 2 == 0)
                {
                    if (!didimonRegex.IsMatch(input))
                    {
                        return;
                    }

                    var found = didimonRegex.Match(input).Value;
                    var index = input.IndexOf(found);
                    Console.WriteLine(found);
                    input = input.Substring(index + found.Length);
                }
                else
                {
                    if (!bojomonRegex.IsMatch(input))
                    {
                        return;
                    }

                    var found = bojomonRegex.Match(input).Value;
                    var index = input.IndexOf(found);
                    Console.WriteLine(found);
                    input = input.Substring(index + found.Length);

                }

                count++;
            }
        }
    }
}
