using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Camera_View
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var skip = nums[0];
            var take = nums[1] + 1;
            var regex = @"((\|<)(.{" + skip + @"})(.{0," + take + @"}))(?=\2|$)";
            var text = Console.ReadLine();
            var views = Regex.Matches(text, regex).Cast<Match>().Select(m => m.Groups[4].Value).ToArray();

            Console.WriteLine(string.Join(", ", views));
        }
    }
}
