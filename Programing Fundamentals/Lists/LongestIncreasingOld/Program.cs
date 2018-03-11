using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingOld
{
    class Program
    {
        const int NO_PREVIOUS = -1;

        static void Main()
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] len = new int[seq.Length];
            int[] prev = new int[seq.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence(seq, len, prev);

            //Console.WriteLine(String.Join(", ", seq));
            //Console.WriteLine("len[]  = " + String.Join(", ", len));
            //Console.WriteLine("prev[] = " + String.Join(", ", prev));

            PrintLongestIncreasingSubsequence(seq, prev, bestIndex);
        }

        private static int CalculateLongestIncreasingSubsequence(
            int[] seq, int[] len, int[] prev)
        {
            int bestLen = 0;
            int bestIndex = 0;
            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = NO_PREVIOUS;
                for (int i = 0; i <= x - 1; i++)
                {
                    if (seq[i] < seq[x] && 1 + len[i] > len[x])
                    {
                        len[x] = 1 + len[i];
                        prev[x] = i;
                        if (len[x] > bestLen)
                        {
                            bestLen = len[x];
                            bestIndex = x;
                        }
                    }
                }
            }
            return bestIndex;
        }

        static void PrintLongestIncreasingSubsequence(int[] seq, int[] prev, int index)
        {
            List<int> lis = new List<int>();
            while (index != NO_PREVIOUS)
            {
                lis.Add(seq[index]);
                index = prev[index];
            }
            lis.Reverse();
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
