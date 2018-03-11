using System;

namespace Problem_14._Integer_to_Hex_and_Binary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(num, 16).ToUpper());
            Console.WriteLine(Convert.ToString(num, 2));

        }
    }
}
