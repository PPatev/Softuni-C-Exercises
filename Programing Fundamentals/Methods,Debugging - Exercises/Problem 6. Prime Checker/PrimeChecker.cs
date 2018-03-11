using System;

namespace Problem_6._Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            var isPrime = true;
            if (n == 1 || n == 0)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            var end =(long) Math.Ceiling(Math.Sqrt(n));
            for (long i = 2; i <= end; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
