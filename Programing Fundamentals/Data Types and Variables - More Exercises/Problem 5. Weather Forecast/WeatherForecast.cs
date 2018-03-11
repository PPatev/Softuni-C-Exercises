using System;

namespace Problem_5._Weather_Forecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            if (num.Contains("."))
            {
                Console.WriteLine("Rainy");
                return;
            }
            else
            {
                var number = long.Parse(num);

                if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
                {
                    Console.WriteLine("Sunny");
                    return;
                }

                if (number <= int.MaxValue && number >= int.MinValue)
                {
                    Console.WriteLine("Cloudy");
                    return;
                }

                Console.WriteLine("Windy");
                return;
            }
        }
    }
}
