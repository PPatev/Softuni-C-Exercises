using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum.ToString("D4")} {secondNum.ToString("D4")} {thirdNum.ToString("D4")} {fourthNum.ToString("D4")}");
        }
    }
}
