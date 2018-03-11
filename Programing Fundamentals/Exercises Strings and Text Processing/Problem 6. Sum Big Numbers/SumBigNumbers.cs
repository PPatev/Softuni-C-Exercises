using System;

namespace Problem_6._Sum_Big_Numbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().TrimStart('0');
            var num2 = Console.ReadLine().TrimStart('0');
            var result = "";
            var longer = num1.Length >= num2.Length ? num1.ToCharArray() : num2.ToCharArray();
            var shorter = num1.Length < num2.Length ? num1.ToCharArray() : num2.ToCharArray();
            Array.Reverse(longer);
            Array.Reverse(shorter);
            var rem = 0;
            var i = 0;
            while (i < longer.Length)
            {
                if (i < shorter.Length)
                {
                    var summed = int.Parse(longer[i].ToString()) + int.Parse(shorter[i].ToString());
                    summed += rem;
                    if (summed > 9)
                    {
                        
                    }
                    else
                    {
                        result += summed;
                        rem = 0;
                    }
                }
                else
                {
                    var summed = int.Parse(longer[i].ToString());
                    summed += rem;
                    if (summed > 9)
                    {
                        result += summed % 10;
                        rem = summed / 10;
                    }
                    else
                    {
                        result += summed;
                        rem = 0;
                    }
                }

                i++;
            }

            if (rem > 0)
            {
                result += rem;
            }

            var value = result.ToCharArray();
            Array.Reverse(value);
            Console.WriteLine(new string(value));
        }
    }
}
