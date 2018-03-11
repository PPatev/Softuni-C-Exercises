using System;
using System.Linq;

namespace Problem_7._Multiply_Big_Number
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var bigNum = Console.ReadLine().TrimStart('0');
            var multiplier = int.Parse(Console.ReadLine());
            var result = "";
            
            var rem = 0;
            for (int i = bigNum.Length -1; i >= 0; i--)
            {
                var digit = int.Parse(bigNum[i].ToString());
                var product = digit * multiplier;
                product += rem;

                if (product > 9)
                {
                    result += product % 10;
                    rem = product / 10;
                }
                else
                {
                    result += product;
                    rem = 0;
                }
                
            }

            if (rem > 0)
            {
                result += rem;
            }

            var value = result.ToCharArray();
            Array.Reverse(value);
            var end = new string(value).TrimStart('0');
            if (end == "")
            {
                end = "0";
            }

            Console.WriteLine(end);
        }
    }
}
