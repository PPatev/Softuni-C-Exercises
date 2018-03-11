using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _8._Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regexText = @"<p>(.*?)<\/p>";
            if (Regex.IsMatch(text, regexText))
            {
                var extracted = Regex.Matches(text, regexText).Cast<Match>().Select(m => m.Groups[1].Value).ToArray();
                var result = new StringBuilder();

                for (int i = 0; i < extracted.Length; i++)
                {
                    var replaced = Regex.Replace(extracted[i], @"[^0-9a-z]+", " ");
                    for (int j = 0; j < replaced.Length; j++)
                    {
                        var symbol = replaced[j];
                        if (char.IsLetter(symbol))
                        {
                            if (symbol >= 110)
                            {
                                symbol = (char)((int)symbol - 13); 
                            }
                            else
                            {
                                symbol = (char)((int)symbol + 13);
                            }
                        }

                        result.Append(symbol);
                    }
                }
                
                Console.WriteLine(result.ToString());
            }
        }
    }
}
