using System;

namespace Exam_Preparation_II
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var avgLapsPerRunner = decimal.Parse(Console.ReadLine());
            var lengthOfTrack = int.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var maxRunners = marathonDays * capacityOfTrack;
            if (numberOfRunners < maxRunners)
            {
                maxRunners = numberOfRunners;
            }

            var totalMeters = maxRunners * avgLapsPerRunner * lengthOfTrack;
            var totalKilometers = Math.Round(totalMeters / (decimal) 1000.0, 2);
            var moneyRaised = Math.Round( totalKilometers * moneyPerKilometer, 2);

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
