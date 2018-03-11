using System;

namespace Problem_18._Different_Integers_Size
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var str = "";
            // sbyte < byte < short < ushort < int < uint < long
            try
            {
                var n = long.Parse(num);

                if (n <= sbyte.MaxValue && n >= sbyte.MinValue)
                {
                    str += "* sbyte\n";
                    
                }

                if (n <= byte.MaxValue && n >= byte.MinValue)
                {
                    str += "* byte\n";
                }

                if (n <= short.MaxValue && n >= short.MinValue)
                {
                    str += "* short\n";
                }

                if (n <= ushort.MaxValue && n >= ushort.MinValue)
                {
                    str += "* ushort\n";
                }

                if (n <= int.MaxValue && n >= int.MinValue)
                {
                    str += "* int\n";

                }

                if (n <= uint.MaxValue && n >= uint.MinValue)
                {
                    str += "* uint\n";
                }

                if (n <= long.MaxValue && n >= long.MinValue)
                {
                    str += "* long\n";
                }

                Console.WriteLine($"{n} can fit in:\n{str}");
            }
            catch (Exception)
            {
                Console.WriteLine($"{num} can't fit in any type");
            }


        }
    }
}
