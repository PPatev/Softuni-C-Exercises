using System;
using System.Linq;

namespace Problem_2___Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var length = list.Count();
            var attack = new bool[length];

            for (int i = 0; i < length; i++)
            {
                var target = list[i] >= length ? list[i] % length : list[i];
                var result = Math.Abs(i - target);
                if (i == target)
                {
                    Console.WriteLine($"{i} performed harakiri");
                }
                else if (result % 2 == 0)
                {
                    Console.WriteLine($"{i} x {target} -> {i} wins");
                }
                else
                {
                    Console.WriteLine($"{i} x {target} -> {target} wins");
                }

            }
        }
    }
}
