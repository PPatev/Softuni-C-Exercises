using System;

namespace Arrays___Exercises
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Trim().Split(' ');
            string[] words2 = Console.ReadLine().Trim().Split(' ');

            var length = FindCommonLength(words1, words2);
            Console.WriteLine(length);
            
        }

        private static int FindCommonLength(string[] words1, string[] words2)
        {
            var lengthLeft = 0;
            var end = words1.Length <= words2.Length ? words1.Length : words2.Length;
            if (words1[0] == words2[0])
            {
                for (int i = 0; i < end; i++)
                {
                    if (words1[i] == words2[i])
                    {
                        lengthLeft++;
                    }
                }
            }

            var lengthRight = 0;
            if (words1[words1.Length - 1] == words2[words2.Length - 1])
            {
                Array.Reverse(words1);
                Array.Reverse(words2);
                for (int i = 0; i < end; i++)
                {
                    if (words1[i] == words2[i])
                    {
                        lengthRight++;
                    }
                }
            }

            return lengthLeft >= lengthRight ? lengthLeft : lengthRight;
        }
    }
}
