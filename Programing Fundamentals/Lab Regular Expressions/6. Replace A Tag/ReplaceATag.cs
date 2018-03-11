using System;
using System.Text.RegularExpressions;

namespace _6._Replace_A_Tag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var replacement = @"[URL href=$1]$2[/URL]";
            var str = Console.ReadLine();

            while (str != "end")
            {
                var replaced = Regex.Replace(str, pattern, replacement);
                Console.WriteLine(replaced);
                str = Console.ReadLine();
            }
        }
    }
}
