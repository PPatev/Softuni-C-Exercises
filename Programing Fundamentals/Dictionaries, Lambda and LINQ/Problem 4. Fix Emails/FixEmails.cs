using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Fix_Emails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            var line = Console.ReadLine();
            var count = 1;
            var name = "";

            while (line != "stop")
            {
                if (count % 2 != 0)
                {
                    name = line;
                }
                else
                {
                    if (!line.ToLower().EndsWith("us") && !line.ToLower().EndsWith("uk"))
                    {
                        if (!emails.ContainsKey(name))
                        {
                            emails.Add(name, line);
                        }
                        else
                        {
                            emails[name] = line;
                        }
                    }
                }

                count++;
                line = Console.ReadLine();
            }

            var lines = emails.Select(kvp => kvp.Key + " -> " + kvp.Value);
            Console.WriteLine(string.Join(Environment.NewLine, lines));

        }
    }
}
