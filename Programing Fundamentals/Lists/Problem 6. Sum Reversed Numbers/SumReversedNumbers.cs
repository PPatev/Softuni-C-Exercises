using System;
using System.Linq;

namespace Problem_6._Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            var sum = 0L;

            for (int i = 0; i < list.Count; i++)
            {
                var strChar = list[i].ToCharArray();
                Array.Reverse(strChar);
                sum += int.Parse(new string(strChar));
            }

            Console.WriteLine(sum);
        }
    }
}
