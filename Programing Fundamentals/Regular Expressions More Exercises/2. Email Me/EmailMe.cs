using System;
using System.Linq;

namespace _2._Email_Me
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var index = email.IndexOf('@');
            var before = email.Substring(0, index).Select(c => (int) c).Sum();
            var after = email.Substring(index + 1).Select(c => (int)c).Sum();

            if (before - after >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
