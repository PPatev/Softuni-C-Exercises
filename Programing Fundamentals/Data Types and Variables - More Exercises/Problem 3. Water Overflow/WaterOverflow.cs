using System;

namespace Problem_3._Water_Overflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int tank = 0;
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var water = int.Parse(Console.ReadLine());
                if (tank + water <= byte.MaxValue)
                {
                    tank += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(tank);
        }
    }
}
