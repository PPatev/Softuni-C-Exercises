using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Longest_Increasing_Subsequence
{
    class Lis
    {

        static void Main(string[] args)
        {
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var len = new List<List<int>>();
            

            for (int i = 0; i < list.Count; i++)
            {
                var lis = new List<int>();
                lis.Add(list[i]);
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] > list[i])
                    {
                        lis.Add(list[j]);
                    }
                }

                if (len.Count > 0)
                {
                    len.RemoveAll(x => x.Count < lis.Count);
                    len.Add(lis);
                }
                else
                {
                    len.Add(lis);
                }
            }

            Console.WriteLine(string.Join(" ", len[0].Select(x => x.ToString()).ToList()));
        }
        
    }
}
