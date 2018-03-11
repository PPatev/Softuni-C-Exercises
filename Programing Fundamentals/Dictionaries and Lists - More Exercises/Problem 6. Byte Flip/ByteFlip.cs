using System;
using System.Globalization;
using System.Linq;

namespace Problem_6._Byte_Flip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Reverse()
                .Select(x => (char)Convert.ToInt32(x, 16))
                .ToArray();

            Console.WriteLine(new string(arr));
        }
    }
}
