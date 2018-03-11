using System;

namespace Problem_9._Make_a_Word
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var str = "";

            for (int i = 0; i < lines; i++)
            {
                str += Console.ReadLine();
            }

            Console.WriteLine($"The word is: {str}");
        }
    }
}
