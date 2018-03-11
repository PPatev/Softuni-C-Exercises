using System;

namespace ProgFundBasicSyntax
{
    class RectArea
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;

            Console.WriteLine("{0:F2}", area);

        }
    }
}
