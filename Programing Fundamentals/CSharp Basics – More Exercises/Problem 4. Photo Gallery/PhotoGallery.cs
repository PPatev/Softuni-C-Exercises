using System;

namespace Problem_4._Photo_Gallery
{
    class PhotoGallery
    {
        static String BytesToString(int byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
            {
                return "0" + suf[0];
            }
                
            int bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();
            var month = Console.ReadLine();
            var year = Console.ReadLine();
            var hours = Console.ReadLine();
            var minutes = Console.ReadLine();
            var photoSize = int.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());

            if (int.Parse(day) < 10)
            {
                day = "0" + day.ToString();
            }

            if (int.Parse(month) < 10)
            {
                month = "0" + month.ToString();
            }

            if (int.Parse(hours) < 10)
            {
                hours = "0" + hours.ToString();
            }

            if (int.Parse(minutes) < 10)
            {
                minutes = "0" + minutes.ToString();
            }

            var orientation = "";

            if (photoWidth > photoHeight)
            {
                orientation = "landscape";
            } else if (photoWidth < photoHeight)
            {
                orientation = "portrait";
            }
            else 
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day}/{month}/{year} {hours}:{minutes}");
            Console.WriteLine($"Size: {BytesToString(photoSize)}");
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");

        }
    }
}
