using System;

namespace Problem_4._Variable_in_Hexadecimal_Format
{
    class VariableHexadecimalFormat
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt16(Console.ReadLine(), 16);

            Console.WriteLine(num);
        }
    }
}
