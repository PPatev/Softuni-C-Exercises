using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var countriesPopulation = new Dictionary<string, long>();
            var countriesCitiesPopulation = new Dictionary<string, Dictionary<string, long>>();
            

            var line = Console.ReadLine();
            while (line != "report")
            {
                var input = line.Split('|');
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);
                var cityCountry = city + "-" + country;

                if (!countriesPopulation.ContainsKey(country))
                {
                    countriesPopulation.Add(country, population);
                    var dict = new Dictionary<string, long>();
                    dict.Add(city, population);
                    countriesCitiesPopulation.Add(country,dict);
                }
                else
                {
                    var people = countriesPopulation[country];
                    people += population;
                    countriesPopulation[country] = people;

                    var dict = countriesCitiesPopulation[country];
                    dict.Add(city, population);
                    countriesCitiesPopulation[country] = dict;
                }

                line = Console.ReadLine();
            }

            var keys = countriesPopulation.Keys.OrderByDescending(c => countriesPopulation[c]);
            foreach (var country in keys)
            {
                Console.WriteLine($"{country} (total population: {countriesPopulation[country]})");
                var cities = countriesCitiesPopulation[country];
                var citiesKeySorted = cities.Keys.OrderByDescending(c => cities[c]);
                foreach (var city in citiesKeySorted)
                {
                    Console.WriteLine($"=>{city}: {cities[city]}");
                }
            }

        }
    }
}
