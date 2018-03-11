using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Pairs_by_Difference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == diff)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
