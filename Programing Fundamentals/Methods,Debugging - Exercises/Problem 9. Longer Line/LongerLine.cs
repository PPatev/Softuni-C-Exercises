using System;

namespace Problem_9._Longer_Line
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            var points = new double[8];
            points[0] = double.Parse(Console.ReadLine());
            points[1] = double.Parse(Console.ReadLine());
            points[2] = double.Parse(Console.ReadLine());
            points[3] = double.Parse(Console.ReadLine());
            points[4] = double.Parse(Console.ReadLine());
            points[5] = double.Parse(Console.ReadLine());
            points[6] = double.Parse(Console.ReadLine());
            points[7] = double.Parse(Console.ReadLine());

            var longest = FindLongest(points);

            Console.WriteLine("({0}, {1})({2}, {3})", longest[0], longest[1], longest[2], longest[3]);
        }

        private static double[] FindLongest(double[] points)
        {
            var first = Math.Sqrt(Math.Pow(points[2] - points[0], 2) + Math.Pow(points[3] - points[1], 2));
            var second = Math.Sqrt(Math.Pow(points[6] - points[4], 2) + Math.Pow(points[7] - points[5], 2));
            var result = new double[4];

            if (first > second)
            {
                return FindClosest(points[0], points[1], points[2], points[3]);
            }
            else if (first == second)
            {
                result[0] = points[0];
                result[1] = points[1];
                result[2] = points[2];
                result[3] = points[3];

                return result;
            }

            return FindClosest(points[4], points[5], points[6], points[7]);
        }

        private static double[] FindClosest(double x1, double y1, double x2, double y2)
        {
            var closest = new double[4];
            var first = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            var second = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (first < second)
            {
                closest[0] = x1;
                closest[1] = y1;
                closest[2] = x2;
                closest[3] = y2;
            }
            else
            {
                closest[0] = x2;
                closest[1] = y2;
                closest[2] = x1;
                closest[3] = y1;
            }

            return closest;
        }
    }
}
