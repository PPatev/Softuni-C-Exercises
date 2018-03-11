using System;

namespace Problem_5._Boolean_Variable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool var1 = Convert.ToBoolean(Console.ReadLine());

            if (var1)
            {
                Console.WriteLine("Yes");
            }

            if (!var1)
            {
                Console.WriteLine("No");
            }
        }
    }
}
