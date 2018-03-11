using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Kamino_Factory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            var currentLongest = new int[] { 0, 0, 0};
            var bestSequence = new int[length];
            var bestIndex = 1;
            var index = 1;

            while (line != "Clone them!")
            {
                var sequence = line.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var longest = LongestSubsequenceOnes(sequence);
                if (longest[1] > currentLongest[1])
                {
                    currentLongest = longest;
                    bestSequence = sequence;
                    bestIndex = index;
                }
                else if (longest[1] == currentLongest[1])
                {
                    //If there are several sequences with same length of subsequence of ones,
                    //print the one with the leftmost starting index, 
                    //if there are several sequences with same length and starting index, 
                    //select the sequence with the greater sum of its elements
                    if (longest[0] < currentLongest[0])
                    {
                        currentLongest = longest;
                        bestSequence = sequence;
                        bestIndex = index;
                    }
                    else if (longest[0] == currentLongest[0])
                    {
                        if (currentLongest[2] < longest[2])
                        {
                            currentLongest = longest;
                            bestSequence = sequence;
                            bestIndex = index;
                        }
                    }
                }

                index++;
                line = Console.ReadLine();
            }


            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {currentLongest[2]}.");
            Console.WriteLine(string.Join(" ", bestSequence.Select(e => e.ToString())));

        }

        private static int[] LongestSubsequenceOnes(int[] sequence)
        {
            var list = new List<int>();
            var max = 0;
            var startIndex = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 1)
                {
                    list.Add(1);
                }
                else
                {
                    if (list.Count() > max)
                    {
                        max = list.Count();
                        startIndex = i - max;
                    }

                    list = new List<int>();
                }

                if (i == sequence.Length - 1)
                {
                    if (list.Count() == sequence.Length)
                    {
                        max = list.Count();
                    }
                }
            }

            return new int[] { startIndex, max, sequence.Sum() };
        }
    }
}
