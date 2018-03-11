using System;

namespace Problem_4._Tourist_Information
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            //miles to kilometers, inches to centimeters, 
            //feet to centimeters, yards to meters and gallons to liters.
            var unit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());
            var converted = 0.0;
            var convertedUnit = "";

            switch (unit)
            {
                case "miles":
                    converted = value * 1.6; convertedUnit = "kilometers"; break;
                case "inches":
                    converted = value * 2.54; convertedUnit = "centimeters"; break;
                case "feet":
                    converted = value * 30.0; convertedUnit = "centimeters"; break;
                case "yards":
                    converted = value * 0.91; convertedUnit = "meters"; break;
                case "gallons":
                    converted = value * 3.8; convertedUnit = "liters"; break;
            }

            Console.WriteLine($"{value} {unit} = {converted:F2} {convertedUnit}");
        }
    }
}
