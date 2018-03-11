using System;
using System.Text.RegularExpressions;

namespace _6._Valid_Usernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = @"^[A-Za-z]\w{2,24}$";
            var previous = "";
            var max = 0;
            var maxFirst = "";
            var maxSecond = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input[i], regex))
                {
                    if (previous.Equals(""))
                    {
                        previous = Regex.Match(input[i], regex).Value;
                        continue;
                    }

                    var length = previous.Length + input[i].Length;
                    if (length > max)
                    {
                        max = length;
                        maxFirst = previous;
                        maxSecond = input[i];
                    }

                    previous = input[i];
                }
            }

            Console.WriteLine(maxFirst);
            Console.WriteLine(maxSecond);
        }
    }
}
