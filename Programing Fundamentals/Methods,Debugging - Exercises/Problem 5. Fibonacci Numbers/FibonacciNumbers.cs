using System;

namespace Problem_5._Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static long Fib(long n)
        {
            if (n <= 0)
            {
                return 1L;
            }

            if (n == 1)
            {
                return 1L;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
