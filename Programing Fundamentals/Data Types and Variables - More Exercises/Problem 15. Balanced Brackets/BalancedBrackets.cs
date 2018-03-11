using System;

namespace Problem_15._Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var balance = 0;
            var balanced = false;


            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                if (input == "(")
                {
                    balance++;
                    if (balance >= 1)
                    {
                        balanced = false;
                    }
                }
                else if (input == ")")
                {
                    balance--;
                    if (balance == 0)
                    {
                        balanced = true;
                    }
                    else
                    {
                        balanced = false;
                    }
                }
            }

            Console.WriteLine(balanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
