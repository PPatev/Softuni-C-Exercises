using System;

namespace Problem_14._Boat_Simulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            var firstBoat = Console.ReadLine()[0];
            var secondBoat = Console.ReadLine()[0];
            var lines = int.Parse(Console.ReadLine());

            var firstMoves = 0;
            var secondMoves = 0;

            for (int i = 1; i <= lines; i++)
            {
                var line = Console.ReadLine();
                if (line == "UPGRADE")
                {
                    firstBoat = (char) (firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }

                if (i % 2 != 0)
                {
                    firstMoves += line.Length;
                }
                else
                {
                    secondMoves += line.Length;
                }

                if (firstMoves >= 50 || secondMoves >= 50)
                {
                    break;
                }
            }



            Console.WriteLine(firstMoves > secondMoves ? firstBoat : secondBoat);
        }
    }
}
