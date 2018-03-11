using System;

namespace Problem_4._Numbers_in_Reversed_Order
{
    class NumbersReversedOrder
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            Console.WriteLine(Reverse(num));
        }

        static string Reverse(string number)
        {
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
