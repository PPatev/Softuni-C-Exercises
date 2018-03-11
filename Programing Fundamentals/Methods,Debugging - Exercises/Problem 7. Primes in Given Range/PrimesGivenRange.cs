using System;
using System.Collections.Generic;

namespace Problem_7._Primes_in_Given_Range
{
    class PrimesGivenRange
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(", ", FindPrimesInRange(start, end)));
        }

        static List<int> FindPrimesInRange(int startNum,int endNum)
        {
            var primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }


            return primes;
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

            var end = (long)Math.Ceiling(Math.Sqrt(n));
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
