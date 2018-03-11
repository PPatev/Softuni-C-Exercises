using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Magic_Exchangeable_Words
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var word1 = input[0];
            var word2 = input[1];
            Console.WriteLine(CheckIfMagic(word1, word2) ? "true" : "false");

        }

        private static bool CheckIfMagic(string word1, string word2)
        {
            var dict = new Dictionary<char, char>();
            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if (!dict.ContainsKey(word1[i]))
                    {
                        dict.Add(word1[i], word2[i]);
                    }
                    else
                    {
                        if (dict[word1[i]] != word2[i])
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                
                var longer = word2.Length > word1.Length ? word2 : word1;
                var shorter = word2.Length < word1.Length ? word2 : word1;

                for (int i = 0; i < shorter.Length; i++)
                {
                    if (!dict.ContainsKey(shorter[i]))
                    {
                        dict.Add(shorter[i], longer[i]);
                    }
                    else
                    {
                        if (dict[word1[i]] != word2[i])
                        {
                            return false;
                        }
                    }
                }
                //The two words may not have the same length, 
                //if such is the case they are exchangeable only if 
                //the longer one doesn't have more types of characters then the shorter one 
                if (longer.ToCharArray().Distinct().Count() > shorter.Length)
                {
                    return false;
                }
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    if (!dict.ContainsValue(longer[i]) || !dict.ContainsKey(longer[i]))
                    {
                        return false;
                    }
                }
            }

            

            return true;
        }
    }
}
