using System;

namespace Problem_8._Center_Point
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());


            Console.WriteLine("({0})", String.Join(", ", FindClosest(x1, y1, x2, y2)));
        }

        private static double[] FindClosest(double x1, double y1, double x2, double y2)
        {
            var closest = new double[2];
            var first = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            var second = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (first < second)
            {
                closest[0] = x1;
                closest[1] = y1;
            }
            else
            {
                closest[0] = x2;
                closest[1] = y2;
            }

            return closest;
        }
    }
}
