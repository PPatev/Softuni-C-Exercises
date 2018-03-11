using System;

namespace Problem_9._Count_the_Integers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            var integers = 0;

            while (true)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    integers++;
                }
                catch (Exception e)
                {
                    break;
                }
            }

            Console.WriteLine(integers);
        }
    }
}
