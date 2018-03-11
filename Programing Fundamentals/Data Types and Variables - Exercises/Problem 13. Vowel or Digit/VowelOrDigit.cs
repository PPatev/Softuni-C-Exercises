using System;

namespace Problem_13._Vowel_or_Digit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine()[0];
            if (symbol <= 57 && symbol >= 48)
            {
                Console.WriteLine("digit");
            } else
            {
                switch (symbol.ToString().ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                    case "y": Console.WriteLine("vowel"); break;
                    default: Console.WriteLine("other"); break;
                }
            }
        }
    }
}
