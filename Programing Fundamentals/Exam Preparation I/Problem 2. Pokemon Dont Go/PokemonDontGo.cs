using System;
using System.Linq;

namespace Problem_2._Pokemon_Dont_Go
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            long sum = 0;

            while (arr.Count() > 0)
            {
                var index = int.Parse(Console.ReadLine());
                int element;
                if (index < 0)
                {
                    var first = arr[0];
                    var last = arr[arr.Count() - 1];
                    arr[0] = last;
                    element = first;
                }
                else if (index >= arr.Count())
                {
                    var first = arr[0];
                    var last = arr[arr.Count() - 1];
                    arr.RemoveAt(arr.Count() - 1);
                    arr.Add(first);
                    element = last;
                }
                else
                {
                    element = arr[index];
                    arr.RemoveAt(index);
                }

                arr = arr.Select(e => {
                    if (e <= element)
                    {
                        return e + element;
                    }

                    return e - element;
                }).ToList();
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
