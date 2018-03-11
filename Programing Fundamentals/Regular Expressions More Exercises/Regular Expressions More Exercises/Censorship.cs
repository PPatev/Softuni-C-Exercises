using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_More_Exercises
{
    class Censorship
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

            Console.WriteLine(Regex.Replace(sentence, word, new string('*', word.Length)));
        }
    }
}
