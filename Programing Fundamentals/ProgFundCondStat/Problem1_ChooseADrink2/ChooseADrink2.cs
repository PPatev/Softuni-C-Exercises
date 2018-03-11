using System;

namespace Problem1_ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    break;
                case "Businesswoman":
                    price = 1.00;
                    break;
                case "Businessman":
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
            }

            var sumToPay = quantity * price;

            Console.WriteLine("The {0} has to pay {1:F2}.", profession, sumToPay);
        }
    }
}
