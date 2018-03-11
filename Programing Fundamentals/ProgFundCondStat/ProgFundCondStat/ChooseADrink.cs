using System;

namespace ProgFundCondStat
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var drink = "";

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "Businessman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }

            Console.WriteLine(drink);
        }
    }
}
