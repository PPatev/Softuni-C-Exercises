using System;
using System.Linq;

namespace Problem_7._Bomb_Numbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (list.Contains(bomb[0]))
            {
                var index = list.IndexOf(bomb[0]);
                var start = index - bomb[1] < 0 ? 0 : index - bomb[1];
                var count = start + (2 * bomb[1]) < list.Count ? (2 * bomb[1] + 1) : list.Count - start;
                list.RemoveRange(start, count);
            }

            Console.WriteLine(list.Sum());

        }
    }
}
