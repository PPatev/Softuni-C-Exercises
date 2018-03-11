using System;

namespace CSharp_Basics___More_Exercises
{
    class XProblem
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == (n / 2))
                {
                    Console.WriteLine($"{new String(' ', ((n - 1) / 2))}x{new String(' ', ((n - 1) / 2))}");
                } else if (i < (n / 2))
                {
                    Console.WriteLine($"{new String(' ', i)}x{new String(' ', n - 2 - (2 * i))}x{new String(' ', i)}");
                } else
                {
                    Console.WriteLine($"{new String(' ', n - 1 - i)}x{new String(' ', (2 * i) - n)}x{new String(' ', n - 1 - i)}");
                }
            }
        }
    }
}
