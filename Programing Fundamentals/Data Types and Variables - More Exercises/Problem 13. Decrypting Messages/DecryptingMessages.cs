using System;

namespace Problem_13._Decrypting_Messages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var lines = int.Parse(Console.ReadLine());
            var message = "";

            for (int i = 0; i < lines; i++)
            {
                message += (char)((int)Console.ReadLine()[0] + key);
            }

            Console.WriteLine(message);
        }
    }
}
