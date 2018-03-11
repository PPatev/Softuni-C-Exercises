using System;
using System.Linq;

namespace Problem_9._Jump_Around
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                        
            int index = 0;
            long sum = arr[index];
            while (true)
            {
                if (index >= 0 && index < arr.Length)
                {
                    if ((arr[index] + index) < arr.Length)
                    {
                        index += arr[index];
                    }
                    else
                    {
                        if ((index - arr[index]) >= 0)
                        {
                            index -= arr[index];
                        }
                        else
                        {
                            break;
                        }
                    }

                    sum += arr[index];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
