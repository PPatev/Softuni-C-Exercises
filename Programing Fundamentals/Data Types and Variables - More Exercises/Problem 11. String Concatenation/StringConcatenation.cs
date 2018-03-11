using System;

namespace Problem_11._String_Concatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var oddEven = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var str = "";

            for (int i = 1; i <= lines; i++)
            {
                var word = Console.ReadLine();

                if (oddEven == "even" && i % 2 == 0)
                {
                    str += word + delimiter;
                }

                if (oddEven == "odd" && i % 2 != 0)
                {
                    str += word + delimiter;
                }
            }

            str = str.Remove(str.Length - 1);

            Console.WriteLine(str);
        }
    }
}
