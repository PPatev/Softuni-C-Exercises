using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7._Query_Mess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var regex = @"^(?<key>.*?)=(?<value>.*?)$";
            
            while (line != "END")
            {
                var kvp = new Dictionary<string, List<string>>();
                if (line.Contains("?"))
                {
                    line = line.Split('?')[1];
                }

                var input = line.Split('&');
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Contains("="))
                    {
                        var replaced = Regex.Replace(input[i], @"(\+|%20)+", " ");
                        if (Regex.IsMatch(replaced, regex))
                        {
                            var key = Regex.Match(replaced, regex).Groups["key"].Value.Trim();
                            var value = Regex.Match(replaced, regex).Groups["value"].Value.Trim();

                            if (!kvp.ContainsKey(key))
                            {
                                var list = new List<string>();
                                list.Add(value);
                                kvp.Add(key, list);
                            }
                            else
                            {
                                var listOld = kvp[key];
                                listOld.Add(value);
                                kvp[key] = listOld;
                            }
                        }
                    }
                }

                foreach (var key in kvp.Keys)
                {
                    var list = kvp[key];
                    Console.Write($"{key}=[{string.Join(", ", list)}]");
                }

                Console.WriteLine();
                line = Console.ReadLine();
            }
        }
    }
}
