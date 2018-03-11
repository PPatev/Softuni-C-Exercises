using System;
using System.Linq;

namespace Arrays_and_Methods
{
    class ArrayStatistic
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            Console.WriteLine($"Min = {arr[0]}");
            Console.WriteLine($"Max = {arr[arr.Length - 1]}");
            long sum = arr.Sum();
            Console.WriteLine($"Sum = {sum}");
            double average = (double) sum / (double)arr.Length;
            Console.WriteLine($"Average = {average}");
        }
    }
}
