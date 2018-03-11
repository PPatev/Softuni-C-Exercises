using System;

namespace Problem_11._Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var output = 0.0;

            switch (figure)
            {
                case "triangle":
                    var side = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    output = TriangleArea(side, height);
                    break;
                case "square":
                    var sideSq = double.Parse(Console.ReadLine());
                    output = SquareArea(sideSq);
                    break;
                case "rectangle":
                    var width = double.Parse(Console.ReadLine());
                    var heightRec = double.Parse(Console.ReadLine());
                    output = RectangleArea(width, heightRec);
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    output = CircleArea(radius);
                    break;
                
            }

            Console.WriteLine("{0:F2}", Math.Round(output, 2));
        }

        private static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private static double SquareArea(double sideSq)
        {
            return Math.Pow(sideSq, 2);
        }

        private static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        private static double TriangleArea(double side, double height)
        {
            return (side * height) / 2.0;
        }
    }
}
