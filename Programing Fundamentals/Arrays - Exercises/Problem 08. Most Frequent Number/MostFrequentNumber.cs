using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8._Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var mostFreq = 0; ;
            int bestCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    mostFreq = arr[i];
                }
            }

            Console.WriteLine(mostFreq);
        }
    }
}
