using System;

namespace Problem_6._Interval_of_Numbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var end = Math.Max(firstNum, secondNum);
            var start = Math.Min(firstNum, secondNum);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
