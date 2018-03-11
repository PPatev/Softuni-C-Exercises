using System;
using System.Linq;

namespace Problem_4._Grab_and_Go
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int index = -1;
            long sum = 0L;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
