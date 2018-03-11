using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Max_Sequence_of_Equal_Elements
{
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestNum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestNum = arr[i];
                }
            }

            var result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += bestNum + " ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}
