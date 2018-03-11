using System;

namespace Problem_10._Sum_of_Chars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var totalSum = 0L; ;

            for (int i = 0; i < lines; i++)
            {
                totalSum += (int) Console.ReadLine()[0];
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
