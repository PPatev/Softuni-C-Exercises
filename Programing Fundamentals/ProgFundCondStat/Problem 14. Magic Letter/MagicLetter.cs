using System;

namespace Problem_14._Magic_Letter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            var firstLetter = Convert.ToByte(Console.ReadLine()[0]);
            var secondLetter = Convert.ToByte(Console.ReadLine()[0]);
            var forbiddenLetter = Convert.ToByte(Console.ReadLine()[0]);

            for (int i = firstLetter; i <= secondLetter; i++)
            {
                for (int j = firstLetter; j <= secondLetter; j++)
                {
                    for (int k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == forbiddenLetter || j == forbiddenLetter || k == forbiddenLetter)
                        {
                            continue;
                        }

                        Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)} ");
                    }
                }
            }
        }
    }
}
