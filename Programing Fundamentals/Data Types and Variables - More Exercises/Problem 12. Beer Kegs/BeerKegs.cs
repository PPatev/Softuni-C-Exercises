using System;

namespace Problem_12._Beer_Kegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var winnerName = "";
            var currentWinner = 0.0;

            for (int i = 0; i < lines; i++)
            {
                var keggName = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var volume = (Math.PI * Math.Pow(radius, 2)) * height;

                if (volume >= currentWinner)
                {
                    currentWinner = volume;
                    winnerName = keggName;
                }
            }

            Console.WriteLine(winnerName);
        }
    }
}
