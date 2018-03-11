using System;
using System.Numerics;

namespace Problem_14._Factorial_Trailing_Zeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CountZeros(n));
        }

        private static int CountZeros(int n)
        {
            var num = Fact(n).ToString();
            var zeros = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                {
                    zeros++;
                }
                else
                {
                    break;
                }
            }

            return zeros;
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
