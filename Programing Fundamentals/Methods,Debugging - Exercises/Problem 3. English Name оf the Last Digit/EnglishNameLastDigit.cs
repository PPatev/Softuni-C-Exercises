using System;

namespace Problem_3._English_Name_оf_the_Last_Digit
{
    class EnglishNameLastDigit
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var lastDigit = int.Parse(num.Substring(num.Length - 1));

            Console.WriteLine(EnglishNameDigit(lastDigit));
        }

        static string EnglishNameDigit(int digit)
        {
            var result = "";

            switch (digit)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
            }

            return result;
        }
    }
}
