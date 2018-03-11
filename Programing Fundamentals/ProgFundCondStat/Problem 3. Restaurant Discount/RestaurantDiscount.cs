using System;

namespace Problem_3._Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = double.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallPrice = 0.0;
            var hallName = "";
            

            if (groupSize <= 50 && groupSize > 0)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }
            else if (groupSize > 120 || groupSize <= 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            var price = 0.0;
            var discount = 0.0;

            switch (package)
            {
                case "Normal":
                    price = 500;
                    discount = 5;
                    break;
                case "Gold":
                    price = 750;
                    discount = 10;
                    break;
                case "Platinum":
                    price = 1000;
                    discount = 15;
                    break;
            }

            var totalPrice = hallPrice + price;
            var discountedPrice = totalPrice - ((totalPrice * discount) / 100);
            var pricePerPerson = discountedPrice / groupSize;

            Console.WriteLine("We can offer you the {0}\nThe price per person is {1:F2}$", hallName, pricePerPerson);
        }
    }
}
