using System;

namespace Problem_17._Print_Part_of_the_ASCII_Table
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();

        }
    }
}
