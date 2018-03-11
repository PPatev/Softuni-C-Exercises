using System;

namespace Problem_15._Neighbour_Wars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());
            var peshoHealth = 100;
            var goshoHealth = 100;
            var round = 1;

            while (true)
            {
                if (round % 2 != 0)
                {
                    goshoHealth -= peshosDamage;

                    if (goshoHealth <= 0)
                    {
                        Console.Write($"Pesho won in {round}th round.");
                        return;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                } else if (round % 2 == 0)
                {
                    peshoHealth -= goshosDamage;

                    if (peshoHealth <= 0)
                    {
                        Console.Write($"Gosho won in {round}th round.");
                        return;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

                round++;
            }
        }
    }
}
