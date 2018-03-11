using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Search_for_a_Number
{
    class Search
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            var newList = new List<int>();

            var endFirst = nums[0] <= list.Count ? nums[0] : list.Count;
            for (int i = 0; i < nums[0]; i++)
            {
                newList.Add(list[i]);
            }

            var endSecond = nums[1] <= newList.Count ? nums[1] : newList.Count;
            for (int i = 0; i < nums[1]; i++)
            {
                newList.RemoveAt(0);
            }

            if (newList.Contains(nums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
