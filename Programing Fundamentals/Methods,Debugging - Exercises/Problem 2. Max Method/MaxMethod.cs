using System;

namespace Problem_2._Max_Method
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a, b), c));
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
