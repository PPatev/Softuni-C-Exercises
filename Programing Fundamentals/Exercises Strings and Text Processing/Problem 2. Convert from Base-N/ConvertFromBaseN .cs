using System;
using System.Numerics;

namespace Problem_2._Convert_from_Base_N
{
    class ConvertFromBaseN
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(' ');
            var baseN = int.Parse(input[0]);
            var number = input[1];
            var result = new BigInteger(0);

            if (baseN <= 10 && baseN >= 2)
            {
                var num = number.ToCharArray();
                Array.Reverse(num);
                for (int i = 0; i < num.Length; i++)
                {
                    var pow = new BigInteger(int.Parse(num[i].ToString())) * BigInteger.Pow(baseN, i);
                    result += pow;
                }

                Console.WriteLine(result);
            }
        }
    }
}
