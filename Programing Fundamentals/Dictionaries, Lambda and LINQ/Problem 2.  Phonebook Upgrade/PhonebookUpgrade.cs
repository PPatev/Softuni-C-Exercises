using System;
using System.Collections.Generic;

namespace Problem_2.__Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();
            while (line != "END")
            {
                var entry = line.Split(' ');

                var command = entry[0];
                switch (command)
                {
                    case "A":
                        var name = entry[1];
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
                        var nameSearch = entry[1];
                        Console.WriteLine("{0}", phonebook.ContainsKey(nameSearch) ? $"{nameSearch} -> {phonebook[nameSearch]}" : $"Contact {nameSearch} does not exist.");
                        break;
                    case "ListAll":
                        foreach (var key in phonebook.Keys)
                        {
                            Console.WriteLine($"{key} -> {phonebook[key]}");
                        }
                        break;
                }

                line = Console.ReadLine();
            }
        }
    }
 }
