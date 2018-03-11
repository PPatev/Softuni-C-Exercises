using System;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var kilometers = miles * 1.60934;
            Console.WriteLine("{0:F2}", kilometers);
        }
    }
}
