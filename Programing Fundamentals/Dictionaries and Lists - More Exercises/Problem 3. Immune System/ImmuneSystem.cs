using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Immune_System
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            var initialHealth = long.Parse(Console.ReadLine());
            var currentHealth = initialHealth;
            //var viruses = new HashSet<string>();
            var virusTimeToDefeat = new Dictionary<string, long>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var virusName = line;
                var virusStrength = virusName.ToCharArray().Select(x => (int)x).Sum() / 3;
                if (currentHealth >= virusStrength)
                {
                    if (!virusTimeToDefeat.ContainsKey(virusName))
                    {
                        var virusDefeatTimeSec = virusStrength * virusName.Length;
                        virusTimeToDefeat.Add(virusName, virusDefeatTimeSec);

                        var virusDefeatMinutesFirst = virusTimeToDefeat[virusName] / 60;
                        var virusDefeatSecondsfirst = virusTimeToDefeat[virusName] % 60;

                        Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusTimeToDefeat[virusName]} seconds");

                        currentHealth -= virusDefeatTimeSec;
                        if (currentHealth < 0)
                        {
                            Console.WriteLine("Immune System Defeated.");
                            return;
                        }

                        Console.WriteLine($"{virusName} defeated in {virusDefeatMinutesFirst}m {virusDefeatSecondsfirst}s.");
                        Console.WriteLine($"Remaining health: {currentHealth}");

                        currentHealth += (currentHealth * 20) / 100;
                        if (currentHealth > initialHealth)
                        {
                            currentHealth = initialHealth;
                        }

                        line = Console.ReadLine();
                        continue;
                    }

                    var time = virusTimeToDefeat[virusName];
                    time /= 3;
                    
                    var virusDefeatMinutes = time / 60;
                    var virusDefeatSeconds = time % 60;

                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {time} seconds");

                    currentHealth -= time;
                    if (currentHealth < 0)
                    {
                        Console.WriteLine("Immune System Defeated.");
                        return;
                    }

                    Console.WriteLine($"{virusName} defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.");
                    Console.WriteLine($"Remaining health: {currentHealth}");

                    currentHealth += (currentHealth * 20) / 100;
                    if (currentHealth > initialHealth)
                    {
                        currentHealth = initialHealth;
                    }
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}
