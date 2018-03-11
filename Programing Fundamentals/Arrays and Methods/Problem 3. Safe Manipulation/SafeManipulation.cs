using System;
using System.Linq;

namespace Problem_3._Safe_Manipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split(' ');

            while(true)
            {
                string[] command = Console.ReadLine().Trim().Split(' ');
                if (command[0] == "END")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Replace":
                        int pos = int.Parse(command[1]);
                        if (pos < 0 || pos > arr.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        arr[pos] = command[2];
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
