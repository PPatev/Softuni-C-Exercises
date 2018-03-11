using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Manipulate_Array
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split(' ');
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Trim().Split(' ');
                switch (command[0])
                {
                    case "Replace":
                        int pos = int.Parse(command[1]);
                        arr[pos] = command[2];
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
