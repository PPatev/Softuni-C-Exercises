using System;
using System.Linq;

namespace Problem_2._Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = new bool[size];
            var indices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < indices.Length; i++)
            {
                if (indices[i] >= 0 && indices[i] < size)
                {
                    field[indices[i]] = true;
                }
            }

            var line = Console.ReadLine();
            while (line != "end")
            {
                var commands = line.Split(' ');
                var bugIndex = int.Parse(commands[0]);
                var direction = commands[1];
                var flyLength = int.Parse(commands[2]);

                if (!field[bugIndex] || bugIndex < 0 || bugIndex >= size)
                {
                    line = Console.ReadLine();
                    continue;
                }

                field[bugIndex] = false;
                var newIndex = bugIndex;
                newIndex = UpdateIndex(newIndex, direction, flyLength);
                while (CheckNewIndex(newIndex, field))
                {
                    newIndex = UpdateIndex(newIndex, direction, flyLength);
                }

                if (newIndex < 0 || newIndex >= field.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }

                field[newIndex] = true;

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field.Select(b => b ? "1" : "0")));

        }

        private static bool CheckNewIndex(int newIndex, bool[] field)
        {
            if (newIndex < 0 || newIndex >= field.Length)
            {
                return false;
            }

            if (field[newIndex])
            {
                return true;
            }

            return false;
        }

        private static int UpdateIndex(int newIndex, string direction, int flyLength)
        {
            switch (direction)
            {
                case "left":
                    newIndex -= flyLength;
                    break;
                case "right":
                    newIndex += flyLength;
                    break;
            }

            return newIndex;
        }
    }
}
