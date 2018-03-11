using System;

namespace Problem_6.__Catch_the_Thief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var max = 0L;
            var currmax = long.MinValue;

            switch (type)
            {
                case "sbyte":
                    max = sbyte.MaxValue;
                    break;
                case "int":
                    max = int.MaxValue;
                    break;
                case "long":
                    max = long.MaxValue;
                    break;
            }

            for (int i = 0; i < lines; i++)
            {
                var num = long.Parse(Console.ReadLine());
                var a  = max - num;
                
                if ((num > currmax && num <= max))
                {
                    currmax = num;
                }
            }

            Console.WriteLine(currmax);
        }
    }
}
