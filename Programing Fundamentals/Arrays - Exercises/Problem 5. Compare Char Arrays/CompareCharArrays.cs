using System;

namespace Problem_5._Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Trim().Split(' ');
            var arr2 = Console.ReadLine().Trim().Split(' ');
            var end = arr1.Length >= arr2.Length ? arr2.Length : arr1.Length;
            var first = arr1.Length >= arr2.Length ? arr2 : arr1;
            var second = arr1.Length > arr2.Length ? arr1 : arr2;

            for (int i = 0; i < end; i++)
            {
                if (arr1[i][0] > arr2[i][0])
                {
                    first = arr2;
                    second = arr1;
                    break;
                }
                else if (arr1[i][0] < arr2[i][0])
                {
                    first = arr1;
                    second = arr2;
                    break;
                }

                continue;
            }

            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));

        }
    }
}
