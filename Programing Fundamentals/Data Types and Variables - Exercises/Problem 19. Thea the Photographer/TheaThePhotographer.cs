using System;

namespace Problem_19._Thea_the_Photographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            /*
             Total pictures = 1 000, 50% of them are useful -> Filtered pictures = 500 
            Total pictures * filter time = 1000 s
            Filtered pictures * upload time = 500 s
            Total time = 1500 s
             */

            var picturesTaken = long.Parse(Console.ReadLine());
            var filterTimeSec = long.Parse(Console.ReadLine());
            var percentUseful = long.Parse(Console.ReadLine());
            var uploadTimeSec = long.Parse(Console.ReadLine());

            var filterSec = picturesTaken * filterTimeSec;
            var usefulPictures = Math.Ceiling((picturesTaken * percentUseful) / 100.0);
            var uploadSec = (long) usefulPictures * uploadTimeSec;
            var totalSec = filterSec + uploadSec;

            var minutes = totalSec / 60;
            var seconds = totalSec % 60;
            var hours = minutes / 60;
            minutes %= 60;
            var days = hours / 24;
            hours %= 24;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
