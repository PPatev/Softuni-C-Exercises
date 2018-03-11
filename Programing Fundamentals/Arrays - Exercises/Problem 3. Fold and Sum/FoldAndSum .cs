using System;
using System.Linq;

namespace Problem_3._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int resultLength = 2 * k;

            int[] result = new int[resultLength];
            int[] start = new int[k];
            int[] end = new int[k];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < k)
                {
                    start[i] = arr[i];
                }
                else if (i >= 3 * k)
                {
                    end[i - (3 * k)] = arr[i];
                }
                else
                {
                    result[i - k] = arr[i];
                }
            }

            Array.Reverse(start);
            Array.Reverse(end);

            for (int i = 0; i < resultLength; i++)
            {
                if (i < start.Length)
                {
                    result[i] += start[i];
                }
                else
                {
                    result[i] += end[i - k];
                }
            }

            //Console.Write(string.Join(' ', start));
            //Console.WriteLine(" " + string.Join(' ', end));
            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString()).ToArray()));

        }
    }
}
