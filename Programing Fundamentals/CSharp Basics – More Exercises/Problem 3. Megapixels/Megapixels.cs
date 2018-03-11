using System;

namespace Problem_3._Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width}x{height} => {Math.Round((width * height) / 1000000, 1)}MP");
        }
    }
}
