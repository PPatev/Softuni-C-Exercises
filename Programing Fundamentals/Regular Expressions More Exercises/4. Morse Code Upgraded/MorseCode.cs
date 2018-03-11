using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Morse_Code_Upgraded
{
    class MorseCode
    {
        private static string input;

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').Select(v => v.Trim()).ToArray();
            var builder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var morse = input[i]; ;
                var sum = morse.Select(c =>
                {
                    if (c == '0')
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }).ToArray().Sum();

                var regexOne = @"1{2,}";
                var regexZero = @"0{2,}";
                var sumOne = Regex.Matches(morse, regexOne).Cast<Match>().Select(m => m.Value.Length).Sum();
                var sumZero = Regex.Matches(morse, regexZero).Cast<Match>().Select(m => m.Value.Length).Sum();

                sum += sumOne + sumZero;
                builder.Append((char) sum);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
