using System;

namespace Problem_5._Word_in_Plural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            var noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Substring(0, noun.Length - 1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
            }
            else if (noun.EndsWith("sh") || noun.EndsWith("ch"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            
            Console.WriteLine(noun);
        }
    }
}
