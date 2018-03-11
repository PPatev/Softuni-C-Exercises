using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var line = Console.ReadLine();

            while (line != "print")
            {
                var command = line.Split(' ');
                switch (command[0])
                {
                    case "add":
                        var index = int.Parse(command[1]);
                        var element = int.Parse(command[2]);
                        list.Insert(index, element);
                        break;
                    case "addMany":
                        var indx = int.Parse(command[1]);
                        var items = new List<int>();
                        for (int i = 2; i < command.Length; i++)
                        {
                            items.Add(int.Parse(command[i]));
                        }
                        list.InsertRange(indx, items);
                        break;
                    case "contains":
                        var el = int.Parse(command[1]);
                        if (list.Contains(el))
                        {
                            Console.WriteLine(list.IndexOf(el));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        var idx = int.Parse(command[1]);
                        list.RemoveAt(idx);
                        break;
                    case "shift":
                        var positions = int.Parse(command[1]);
                        for (int i = 0; i < positions % list.Count; i++)
                        {
                            var it = list[0];
                            list.RemoveAt(0);
                            list.Add(it);
                        }
                        break;
                    case "sumPairs":
                        var newList = new List<int>();
                        for (int i = 0; i < list.Count; i += 2)
                        {
                            if (i + 1 < list.Count)
                            {
                                newList.Add(list[i] + list[i + 1]);
                            }
                            else
                            {
                                newList.Add(list[i]);
                            }
                        }

                        list = newList;
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", list.Select(x => x.ToString()).ToList()) + "]");

        }
    }
}
