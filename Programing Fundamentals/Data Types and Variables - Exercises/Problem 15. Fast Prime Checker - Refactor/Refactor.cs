using System;

namespace Problem_15._Fast_Prime_Checker___Refactor
{
    class Refactor
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            for (int i = 2; i <= upperLimit; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
