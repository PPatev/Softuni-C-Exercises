using System;
using System.Numerics;

namespace Problem_13._Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fact(n));
        }

        private static BigInteger Fact(int n)
        {
            BigInteger fac = new BigInteger(1);

            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }

            return fac;
        }
    }
}
