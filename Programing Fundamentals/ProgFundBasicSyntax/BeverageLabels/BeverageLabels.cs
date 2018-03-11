using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {productName}:\n{(volume * energyContent) / 100.0}kcal, {(volume * sugarContent) / 100.0}g sugars");
        }
    }
}
