using System;
using System.Linq;

namespace Problem_7._Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                int current = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (current < arr[j])
                    {
                        count++;
                        current = arr[j];
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestPosition = i;
                }
            }

            var result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[i + bestPosition].ToString() + " ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}
