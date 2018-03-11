using System;

namespace Problem_16._Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var eps = 0.000001;
            Console.WriteLine(Math.Abs(num1 - num2) < eps);
        }
    }
}
