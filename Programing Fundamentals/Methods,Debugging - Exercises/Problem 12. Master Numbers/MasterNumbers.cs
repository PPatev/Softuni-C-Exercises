using System;

namespace Problem_12._Master_Numbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsSymetric(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            var holdsEvenDigit = false;
            var num = i.ToString();

            for (int j = 0; j < num.Length; j++)
            {
                if (int.Parse(num[j].ToString()) % 2 == 0)
                {
                    holdsEvenDigit = true;
                }
            }

            return holdsEvenDigit;
        }

        private static bool SumOfDigits(int i)
        {
            var num = i.ToString();
            var sum = 0;
            for (int j = 0; j < num.Length; j++)
            {
                sum += int.Parse(num[j].ToString());
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsSymetric(int i)
        {
            var isSymetric = true;
            if (i < 10 )
            {
                return true;
            }

            var num = i.ToString();

            for (int j = 0; j < num.Length / 2; j++)
            {
                //5225
                if (num[j] == num[num.Length - 1 - j])
                {
                    isSymetric &= true;
                }
                else
                {
                    isSymetric &= false;
                }
            }

            return isSymetric;
        }
    }
}
