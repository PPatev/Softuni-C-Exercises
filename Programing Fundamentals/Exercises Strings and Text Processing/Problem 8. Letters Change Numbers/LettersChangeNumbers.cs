using System;

namespace Problem_8._Letters_Change_Numbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                var firstLetter = current.Substring(0, 1);
                var lastLetter = current.Substring(current.Length - 1, 1);
                var numberStr = current.Substring(1, current.Length - 2);
                var number = decimal.Parse(numberStr);
                var letterPosFirst = (int)firstLetter.ToLower()[0] - 96;
                var letterPosSecond = (int)lastLetter.ToLower()[0] - 96;
                decimal resulted = 0;
                if (char.IsLower(firstLetter[0]))
                {
                    resulted = (letterPosFirst * number);
                }
                else
                {
                    resulted = (number / letterPosFirst);
                }

                if (char.IsLower(lastLetter[0]))
                {
                    resulted += letterPosSecond;
                }
                else
                {
                    resulted -= letterPosSecond;
                }

                result += resulted;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
