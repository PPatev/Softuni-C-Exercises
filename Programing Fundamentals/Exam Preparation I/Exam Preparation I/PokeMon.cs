using System;

namespace Exam_Preparation_I
{
    class PrPokeMonogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            int originalN =  (n * 50 ) / 100;

            while (n >= m)
            {
                count++;
                n -= m;

                if (n == originalN)
                {
                    if (n / y > 0)
                    {
                        n /= y;
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
