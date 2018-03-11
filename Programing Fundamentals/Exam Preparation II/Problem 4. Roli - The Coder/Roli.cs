using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Roli___The_Coder
{
    class Roli
    {
        static void Main(string[] args)
        {
            var events = new Dictionary<string, HashSet<string>>();
            var ids = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "Time for Code")
            {
                if (!line.Contains('#'))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var input = line.Split('#');
                if (input.Length == 2)
                {
                    var id = input[0].Trim();
                    var eventName = "";
                    var participants = new HashSet<string>();
                    if (input[1].Contains("@"))
                    {
                        var split = input[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        eventName = split[0].Trim();
                        participants = new HashSet<string>(split.Skip(1));
                    }
                    else
                    {
                        eventName = input[1].Trim();
                    }

                    

                    if (!ids.ContainsKey(id))
                    {
                        ids.Add(id, eventName);
                        events.Add(eventName, participants);
                    }
                    else
                    {
                        if (ids[id] != eventName)
                        {
                            line = Console.ReadLine();
                            continue;
                        }

                        var oldParticipants = events[eventName];
                        foreach (var participant in participants)
                        {
                            oldParticipants.Add(participant);
                        }
                        events[eventName] = oldParticipants;
                    }
                }

                line = Console.ReadLine();
            }

            var sorted = events.OrderByDescending(e => e.Value.Count()).ThenBy(e => e.Key);
            foreach (var ev in sorted)
            {
                Console.WriteLine($"{ev.Key} - {ev.Value.Count()}");
                var participants = ev.Value.OrderBy(p => p).ToArray();

                if (participants.Count() > 0)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, participants));
                }
            }
        }
    }
}
