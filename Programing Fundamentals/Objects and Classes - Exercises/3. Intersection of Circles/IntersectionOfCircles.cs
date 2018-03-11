using System;
using System.Linq;

namespace _3._Intersection_of_Circles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p1 = new Point() { X = input1[0], Y = input1[1] };
            var p2 = new Point() { X = input2[0], Y = input2[1] };

            var c1 = new Circle() { Center = p1, Radius = input1[2] };
            var c2 = new Circle() { Center = p2, Radius = input2[2] };

            var result = Intersect(c1, c2) ? "Yes" : "No";
            Console.WriteLine(result);
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            var distance = Math.Sqrt(Math.Pow(c2.Center.X - c1.Center.X, 2) + Math.Pow(c2.Center.Y - c1.Center.Y, 2));
            
            return distance <= c1.Radius + c2.Radius;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

    }
}

