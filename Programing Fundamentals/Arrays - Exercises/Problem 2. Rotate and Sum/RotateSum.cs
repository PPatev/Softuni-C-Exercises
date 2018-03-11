using System;
using System.Linq;

namespace Problem_2._Rotate_and_Sum
{
    class RotateSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            

            int[] summed = new int[arr.Length];
            for (int i = 1; i <= k; i++)
            {
                var rotated = Rotate(arr, i);
                for (int j = 0; j < summed.Length; j++)
                {
                    summed[j] += rotated[j];
                }
            }

            Console.WriteLine(string.Join(" ", summed));

        }

        private static int[] Rotate(int[] arr, int k)
        {
            int[] rotated = new int[arr.Length];
            for (int i = 0; i < rotated.Length; i++)
            {
                int j = (i + k) % (arr.Length);
                rotated[j] = arr[i];
            }

            return rotated;
        }
    }
}
