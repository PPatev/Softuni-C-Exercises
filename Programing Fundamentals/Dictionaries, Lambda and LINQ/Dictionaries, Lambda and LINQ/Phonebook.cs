using System;
using System.Collections.Generic;

namespace Dictionaries__Lambda_and_LINQ
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            while (line != "END")
            {
                var entry = line.Split(' ');
                var name = entry[1];
                var command = entry[0];
                switch (command)
                {
                    case "A":
                        var phone = entry[2];
                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        Console.WriteLine("{0}", phonebook.ContainsKey(name) ? $"{name} -> {phonebook[name]}" : $"Contact {name} does not exist.");
                        break;
                }

                line = Console.ReadLine();
            }
        }
    }
}
