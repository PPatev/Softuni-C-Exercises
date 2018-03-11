using System;

namespace Problem_12._Test_Numbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var combinations = 0;
            var sum = 0;

            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2 ; j++)
                {
                    combinations++;
                    sum += 3 * (i * j);

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
