using System;

namespace Problem_8._House_Builder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());

            if (a < 128)
            {
                Console.WriteLine((4 * a) + (10 * b));
            }
            else
            {
                Console.WriteLine((4 * b) + (10 * a));
            }
        }
    }
}
