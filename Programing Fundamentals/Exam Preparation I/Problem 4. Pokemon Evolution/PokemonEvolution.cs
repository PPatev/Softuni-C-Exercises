using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Pokemon_Evolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var pokemonEvolution = new Dictionary<string, List<string[]>>();
            var line = Console.ReadLine();

            while (line != "wubbalubbadubdub")
            {
                //Ekans -> Hybrid -> 100
                var input = line.Split(' ').Where(s => s != "->").ToArray();
                var pokemonName = input[0];

                if (input.Length == 1)
                {
                    if (pokemonEvolution.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        var evolutions = pokemonEvolution[pokemonName];
                        for (int i = 0; i < evolutions.Count(); i++)
                        {
                            Console.WriteLine($"{evolutions[i][0]} <-> {evolutions[i][1]}");
                        }
                    }

                    line = Console.ReadLine();
                    continue;
                }


                var evolutionType = input[1];
                var evolutionIndex = input[2];

                if (!pokemonEvolution.ContainsKey(pokemonName))
                {
                    var evolution = new List<string[]>();

                    evolution.Add(new string[] { evolutionType, evolutionIndex});
                    pokemonEvolution.Add(pokemonName, evolution);
                }
                else
                {
                    var evolution = pokemonEvolution[pokemonName];
                    evolution.Add(new string[] { evolutionType, evolutionIndex });
                    pokemonEvolution[pokemonName] = evolution;
                }

                line = Console.ReadLine();
            }

            if (pokemonEvolution.Count() > 0)
            {
                foreach (var pokemon in pokemonEvolution)
                {
                    var name = pokemon.Key;
                    Console.WriteLine($"# {name}");
                    var evolutions = pokemon.Value;
                    var sortedEvolutions = evolutions.OrderByDescending(e => int.Parse(e[1])).Select(e => $"{e[0]} <-> {e[1]}");
                    
                    Console.WriteLine(string.Join(Environment.NewLine, sortedEvolutions));
                }
            }
        }
    }
}
