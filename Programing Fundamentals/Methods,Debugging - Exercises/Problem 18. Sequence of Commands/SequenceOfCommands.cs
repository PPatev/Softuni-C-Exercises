using System;
using System.Linq;

namespace Problem_18._Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] arguments = command.Trim().Split(ArgumentsDelimiter);
                int[] args = new int[2];

                if (arguments.Length == 3)
                {
                    args[0] = int.Parse(arguments[1]);
                    args[1] = int.Parse(arguments[2]);
                }
                

                PerformAction(array, arguments[0], args);

                PrintArray(array);
                //Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos - 1] *= value;
                    break;
                case "add":
                    arr[pos - 1] += value;
                    break;
                case "subtract":
                    arr[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            var value = array[array.Length - 1]; ;
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = value;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            var value = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = value;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
                
            }

            Console.WriteLine();
        }
    }
}
