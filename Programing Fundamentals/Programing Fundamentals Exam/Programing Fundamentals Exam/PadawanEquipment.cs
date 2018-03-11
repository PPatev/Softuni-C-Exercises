using System;

namespace Programing_Fundamentals_Exam
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var countStudents = int.Parse(Console.ReadLine());
            var priceLightsaber = double.Parse(Console.ReadLine());
            var priceRobes = double.Parse(Console.ReadLine());
            var priceBelt = double.Parse(Console.ReadLine());

            var studentLightsabers = countStudents + (Math.Ceiling(countStudents * 0.10));
            var lightsabers = studentLightsabers * priceLightsaber;
            var robes = priceRobes * countStudents;
            var freeBelts = 0;

            if (countStudents >= 6)
            {
                freeBelts = (countStudents / 6);
            }

            var studentsBelts = (countStudents - freeBelts);
            var belts = priceBelt * studentsBelts;

            var moneyNeeded = lightsabers + robes + belts;

            if (moneyNeeded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(moneyNeeded - money):F2}lv more.");
            }

        }
    }
}
