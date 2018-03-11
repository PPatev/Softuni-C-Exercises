using System;

namespace Problem_8._Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var totalCaloriesAmount = 0;

            for (int i = 0; i < lines; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese": totalCaloriesAmount += 500; break;
                    case "tomato sauce": totalCaloriesAmount += 150; break;
                    case "salami": totalCaloriesAmount += 600; break;
                    case "pepper": totalCaloriesAmount += 50; break;
                }
            }

            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
