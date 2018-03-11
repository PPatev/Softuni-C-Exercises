using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Trim().Split(' ');
            var equal = new List<List<string>>();
            

            for (int i = 0; i < arr.Length; i++)
            {
                var eq = new List<string>();
                eq.Add(arr[i]);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        eq.Add(arr[j]);
                    }
                    else
                    {
                        if (equal.Count > 0)
                        {
                            var lastCount = equal[equal.Count - 1].Count;
                            if (eq.Count > lastCount)
                            {
                                equal.RemoveAt(equal.Count - 1);
                                equal.Add(eq);
                            }

                            i = j - 1;
                            break;
                        }
                        else
                        {
                            equal.Add(eq);
                            i = j - 1;
                            break;
                        }
                    }

                    if (j == arr.Length - 1)
                    {
                        var lastCount = equal[equal.Count - 1].Count;
                        if (eq.Count > lastCount)
                        {
                            equal.RemoveAt(equal.Count - 1);
                            equal.Add(eq);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", equal[0]));
        }
    }
}
