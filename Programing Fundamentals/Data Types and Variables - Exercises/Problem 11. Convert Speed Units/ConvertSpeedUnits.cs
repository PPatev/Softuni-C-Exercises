using System;

namespace Problem_11._Convert_Speed_Units
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            var distanceMeters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float hoursInSec = hours * 3600.0f;
            float minutesInSec = minutes * 60.0f;
            float speedMSec = distanceMeters / (seconds + minutesInSec + hoursInSec);

            float distanceKm = distanceMeters / 1000.0f;
            float minutesHours = minutes / 60.0f;
            float secondsHours = seconds / 3600.0f;

            float speedKmHours = distanceKm / (hours + minutesHours + secondsHours);

            float distanceMiles = distanceMeters / 1609f;
            float speedMilesHour = distanceMiles / (hours + minutesHours + secondsHours);

            Console.WriteLine($"{Math.Round(speedMSec, 6)}");
            Console.WriteLine($"{Math.Round(speedKmHours, 6)}");
            Console.WriteLine($"{Math.Round(speedMilesHour, 6)}");

        }
    }
}
