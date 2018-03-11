using System;

namespace Problem_4._Character_Multiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var str1 = input[0];
            var str2 = input[1];
            var longer = str1.Length > str2.Length ? str1 : str2;
            var shorter = str1.Length <= str2.Length ? str1 : str2;
            ulong result = 0;
            for (int i = 0; i < longer.Length; i++)
            {
                if (i < shorter.Length)
                {
                    result += (ulong) longer[i] * shorter[i];
                    
                }
                else
                {
                    result += (ulong)longer[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
