using System;
using System.Text;

namespace _3._Karate_Strings
{
    class KarateStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var builder = new StringBuilder();
            var found = false;
            var punch = 0;
            var punching = false;
            var strengthLeft = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    found = true;
                    builder.Append(input[i]);
                    continue;
                }

                if (found)
                {
                    if (punch > 0)
                    {
                        strengthLeft = punch;
                    }

                    punch = int.Parse(input[i].ToString()) + strengthLeft;
                    strengthLeft = 0;
                    found = false;
                    punching = true;
                }

                if (punching && punch > 0)
                {
                    punch--;
                    continue;
                }

                if (punch == 0)
                {
                    punching = false;
                }

                if (!found && !punching)
                {
                    builder.Append(input[i]);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
