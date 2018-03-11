using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Skip_Rope
{
    class SkipRope
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var numbers = input.Where(x => Char.IsDigit(x)).ToList();
            var nonnumbers = input.Where(x => !Char.IsDigit(x)).ToArray();
            var takeList = numbers
                .Select((s, i) => new {i, s})
                .Where(n => n.i % 2 == 0)
                .Select(n => n.s)
                .Select(n => int.Parse(n.ToString()))
                .ToArray();

            var skipList = numbers
                .Select((s, i) => new { i, s })
                .Where(n => n.i % 2 != 0)
                .Select(n => n.s)
                .Select(n => int.Parse(n.ToString()))
                .ToArray();
            var result = "";
            var total = 0;
            for (int i = 0; i < takeList.Length; i++)
            {
                var skip = skipList[i];
                var take = takeList[i];
                result += new string(nonnumbers.Skip(total).Take(take).ToArray());
                total += skip + take;
            }

            Console.WriteLine(result);

        }
    }
}
