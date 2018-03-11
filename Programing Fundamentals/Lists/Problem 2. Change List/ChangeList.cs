using System;
using System.Linq;

namespace Problem_2._Change_List
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            var line = Console.ReadLine();
            while (line != "Odd" && line != "Even")
            {
                var command = line.Split(' ');
                switch (command[0])
                {
                    case "Delete":
                        var numToRemove = int.Parse(command[1]);
                        while (list.Contains(numToRemove))
                        {
                            list.Remove(numToRemove);
                        }
                        break;
                    case "Insert":
                        var element = int.Parse(command[1]);
                        var position = int.Parse(command[2]);
                        list.Insert(position, element);
                        break;
                }

                line = Console.ReadLine();
            }

            var result = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (line == "Odd" && list[i] % 2 != 0)
                {
                    result += list[i] + " ";
                }

                if (line == "Even" && list[i] % 2 == 0)
                {
                    result += list[i] + " ";
                }
            }

            Console.WriteLine(result.Trim());
            
        }

    }
}
