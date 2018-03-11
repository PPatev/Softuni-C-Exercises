using System;

namespace Problem_9._Index_of_Letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {((int) word[i]) - 97}");
            }
        }
    }
}
