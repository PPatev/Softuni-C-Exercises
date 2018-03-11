using System;

namespace Problem_10._Cube_Properties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var output = 0.0;

            switch (command)
            {
                case "face":
                    output = Face(side);
                    break;
                case "space":
                    output = Space(side);
                    break;
                case "volume":
                    output = Volume(side);
                    break;
                case "area":
                    output = Area(side);
                    break;
            }

            Console.WriteLine("{0:F2}", Math.Round(output, 2));
        }

        private static double Area(double side)
        {
            return 6 * Math.Pow(side, 2);
        }

        private static double Volume(double side)
        {
            return Math.Pow(side, 3);
        }

        private static double Space(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        private static double Face(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
    }
}
