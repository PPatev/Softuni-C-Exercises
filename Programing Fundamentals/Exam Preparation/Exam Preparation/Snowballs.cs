using System;
using System.Numerics;

namespace Exam_Preparation
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            var numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger maxValue = new BigInteger();
            var maxSnow = 0;
            var maxTime = 0;
            var maxQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQuality = double.Parse(Console.ReadLine());

                var snowballValue = BigInteger.Pow(new BigInteger(snowballSnow / snowballTime), (int)snowballQuality);
                if (maxValue < snowballValue)
                {
                    maxValue = snowballValue;
                    maxSnow = (int)snowballSnow;
                    maxTime = (int)snowballTime;
                    maxQuality = (int)snowballQuality;
                }
            }

            if (numberOfSnowballs > 0)
            {
                Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
            }
        }
    }
}
