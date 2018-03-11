using System;
using System.Linq;

namespace Problem_2._Odd_Filter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var filtered = numbers.Where(n => n % 2 == 0).ToArray();
            var average = filtered.Average();
            var transformed = filtered.Select(x => x >= average ? x + 1 : x - 1).ToArray();
            Console.WriteLine(string.Join(" ", transformed.Select(x => x.ToString()).ToArray()));

        }
    }
}
