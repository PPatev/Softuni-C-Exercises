using System;
using System.Linq;

namespace Dictionaries_and_Lists___More_Exercises
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(' ');
            var timesorted = time.OrderBy(t => t);
            Console.WriteLine(string.Join(", ", timesorted));
        }
    }
}
