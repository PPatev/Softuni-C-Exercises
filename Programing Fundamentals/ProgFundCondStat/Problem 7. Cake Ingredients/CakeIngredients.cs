using System;

namespace Problem_7._Cake_Ingredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var ingerient = Console.ReadLine();
            var numberOfIngredients = 1;

            while (ingerient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingerient}.");

                ingerient = Console.ReadLine();

                if (ingerient != "Bake!")
                {
                    numberOfIngredients++;
                }
            }

            Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
        }
    }
}
