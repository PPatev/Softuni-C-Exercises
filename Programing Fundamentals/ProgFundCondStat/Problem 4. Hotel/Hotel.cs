using System;

namespace Problem_4._Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());

            var studioTotal = 0.0;
            var doubleTotal = 0.0;
            var suiteTotal = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioTotal = nights * 50;
                    if (nights > 7 && month == "October")
                    {
                        studioTotal -= 50;
                    }

                    if (nights > 7)
                    {
                        studioTotal *= 0.95;
                    }

                    doubleTotal = nights * 65;
                    suiteTotal = nights * 75;
                    break;
                case "June":
                case "September":
                    studioTotal = nights * 60;
                    doubleTotal = nights * 72;
                    suiteTotal = nights * 82;

                    if (nights > 14)
                    {
                        doubleTotal *= 0.90;
                    }

                    if (nights > 7 && month == "September")
                    {
                        studioTotal -= 60;
                    }

                    break;
                case "July":
                case "August":
                case "December":
                    studioTotal = nights * 68;
                    doubleTotal = nights * 77;
                    suiteTotal = nights * 89;

                    if (nights > 14)
                    {
                        suiteTotal *= 0.85;
                    }
                    break;
            }



            Console.WriteLine("Studio: {0:F2} lv.", studioTotal);
            Console.WriteLine("Double: {0:F2} lv.", doubleTotal);
            Console.WriteLine("Suite: {0:F2} lv.", suiteTotal);
        }
    }
}
