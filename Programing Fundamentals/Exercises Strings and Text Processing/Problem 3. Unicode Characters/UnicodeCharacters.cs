using System;
using System.Linq;

namespace Problem_3._Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var chars = input
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
