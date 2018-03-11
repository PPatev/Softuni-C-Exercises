using System;
using System.Linq;

namespace Problem_6._Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            long earnings = 0L;
            long expences = 0L;

            var line = Console.ReadLine();
            while (line != "Jail Time")
            {
                var input = line.Trim().Split(' ');
                expences += int.Parse(input[1]);
                var loot = input[0].ToCharArray();
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        earnings += prices[0];
                    }
                    else if (loot[i] == '$')
                    {
                        earnings += prices[1];
                    }
                }

                line = Console.ReadLine();
            }

            if (earnings >= expences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnings - expences}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expences - earnings}.");
            }
        }
    }
}
