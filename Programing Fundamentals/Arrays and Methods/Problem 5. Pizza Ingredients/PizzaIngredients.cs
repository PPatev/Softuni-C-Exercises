using System;

namespace Problem_5._Pizza_Ingredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Trim().Split(' ');
            var length = int.Parse(Console.ReadLine());
            var count = 0;
            var ingredients = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == length)
                {
                    Console.WriteLine($"Adding {arr[i]}.");
                    ingredients += arr[i] + " ";
                    count++;

                    if (count == 10)
                    {
                        break;
                    }
                }
            }


            Console.WriteLine($"Made pizza with total of {count} ingredients.\nThe ingredients are: {string.Join(", ", ingredients.Trim().Split(' '))}.");
        }
    }
}
