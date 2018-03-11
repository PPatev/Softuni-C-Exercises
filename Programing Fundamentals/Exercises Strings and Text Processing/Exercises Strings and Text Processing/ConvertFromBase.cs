using System;
using System.Numerics;

namespace Exercises_Strings_and_Text_Processing
{
    class ConvertFromBase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(' ');
            var baseN = BigInteger.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var result = "";

            if (baseN <= 10 && baseN >= 2)
            {
                while (number > 0)
                {
                    var remainder = number % baseN;
                    result += remainder.ToString();
                    number /= baseN;
                }

                var num = result.ToCharArray();
                Array.Reverse(num);
                Console.WriteLine(new string(num));
            }
        }
    }
}
