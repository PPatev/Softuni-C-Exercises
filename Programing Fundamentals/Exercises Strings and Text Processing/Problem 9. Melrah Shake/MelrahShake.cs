using System;
using System.Text;

namespace Problem_9._Melrah_Shake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder(Console.ReadLine());
            var pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                if (TwoMatchesExist(str, pattern))
                {
                    Console.WriteLine("Shaked it.");
                    str = UpdateStr(str, pattern);
                }
                else
                {
                    break;

                }

                pattern = UpdatePattern(pattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(str.ToString());
        }

        private static StringBuilder UpdateStr(StringBuilder str, string pattern)
        {
            var indexFirst = str.ToString().IndexOf(pattern);
            var lastIndex = str.ToString().LastIndexOf(pattern);
            str = str.Remove(lastIndex, pattern.Length);
            str = str.Remove(indexFirst, pattern.Length);

            return str;
        }

        private static bool TwoMatchesExist(StringBuilder str, string pattern)
        {
            var indexFirst = str.ToString().IndexOf(pattern);

            if (indexFirst < 0)
            {
                return false;
            }

            var lastIndex = str.ToString().LastIndexOf(pattern);
            if (indexFirst == lastIndex)
            {
                return false;
            }

            return true;
        }

        private static string UpdatePattern(string pattern)
        {
            var index = pattern.Length / 2;
            var builder = new StringBuilder(pattern);
            builder.Remove(index, 1);

            return builder.ToString();
        }
    }
}
