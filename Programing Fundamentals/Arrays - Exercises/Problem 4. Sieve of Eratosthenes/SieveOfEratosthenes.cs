using System;

namespace Problem_4._Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            string result = "";

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result += i + " ";
                    for (int j = 2; j < primes.Length; j++)
                    {
                        if (i * j < primes.Length)
                        {
                            primes[i * j] = false;
                        }
                    }
                }
            }

            Console.WriteLine(result.Trim());
        }
    }
}
