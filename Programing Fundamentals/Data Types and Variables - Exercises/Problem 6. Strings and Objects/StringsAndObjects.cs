using System;

namespace Problem_6._Strings_and_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string var1 = Console.ReadLine();
            string var2 = Console.ReadLine();
            object var3 = var1 + " " + var2;
            string var4 = (string) var3;
            Console.WriteLine(var4);
        }
    }
}
