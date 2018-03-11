using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Extract_Sentences_by_Keyword
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var regex = @"([^.?!]*(?<=[.?\s!])" + word + @"(?=[\s.?!])[^.?!]*)[.?!]";
            var text = Console.ReadLine();
            var sentences = Regex.Matches(text, regex).Cast<Match>().Select(m => m.Groups[1].Value.Trim()).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, sentences));
        }
    }
}
