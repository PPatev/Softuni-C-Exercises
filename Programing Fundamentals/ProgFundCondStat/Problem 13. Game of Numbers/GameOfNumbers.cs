using System;

namespace Problem_13._Game_of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var combinations = 0;

            for (int i = num1; i <= num2 ; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        return;
                    }

                    combinations++;
                }
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
        }
    }
}
