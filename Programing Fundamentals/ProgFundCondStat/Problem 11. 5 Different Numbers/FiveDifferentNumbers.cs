using System;

namespace Problem_11._5_Different_Numbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if ((b - a) < 5)
            {
                Console.WriteLine("No");

                return;
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int l = k + 1; l <= b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
