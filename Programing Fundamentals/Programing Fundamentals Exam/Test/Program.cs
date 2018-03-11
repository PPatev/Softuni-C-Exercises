using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            
            var bestIndex = 1;
            var index = 1;
            var startIndex = 0;
            var bestSequence = new int[length];


            while (line != "Clone them!")
            {
                var sequence = line.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var list = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        list.Add(sequence[i]);
                    }
                }

                index++;
                line = Console.ReadLine();
            }
        }
    }
}
