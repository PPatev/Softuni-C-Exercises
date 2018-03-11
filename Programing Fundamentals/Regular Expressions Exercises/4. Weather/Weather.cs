using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            var regex = @"(?<cityCode>[A-Z][A-Z])(?<avgTemp>[0-9]+\.[0-9]{1,2})(?<typeWeather>[A-Za-z]+)\|";
            var cityTemp = new Dictionary<string, double>();
            var cityWeather = new Dictionary<string, string>();

            var line = Console.ReadLine();
            while (line != "end")
            {
                if (Regex.IsMatch(line, regex))
                {
                    var city = Regex.Match(line, regex).Groups["cityCode"].Value;
                    var temp = double.Parse(Regex.Match(line, regex).Groups["avgTemp"].Value);
                    var typeWeather = Regex.Match(line, regex).Groups["typeWeather"].Value;

                    if (!cityTemp.ContainsKey(city))
                    {
                        cityTemp.Add(city, temp);
                        cityWeather.Add(city, typeWeather);
                    }
                    else
                    {
                        cityTemp[city] = temp;
                        cityWeather[city] = typeWeather;
                    }
                }

                line = Console.ReadLine();
            }

            var sorted = cityTemp.OrderBy(kv => kv.Value).Select(c => c.Key);
            foreach (var city in sorted)
            {
                Console.WriteLine($"{city} => {cityTemp[city]:F2} => {cityWeather[city]}"); 
            }

        }
    }
}
