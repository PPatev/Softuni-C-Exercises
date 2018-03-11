using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            var forceSideUsers = new Dictionary<string, HashSet<string>>();
            var forceUsers = new HashSet<string>();
            var regexPipe = @"^(.*?) \| (.*?)$";
            var regexArrow = @"^(.*?)\s{1}->\s{1}(.*?)$";

            var line = Console.ReadLine();
            while (line != "Lumpawaroo")
            {
                if (Regex.IsMatch(line, regexPipe))
                {
                    var forceSide = Regex.Match(line, regexPipe).Groups[1].Value;
                    var forceUser = Regex.Match(line, regexPipe).Groups[2].Value;

                    if (!forceUsers.Contains(forceUser))
                    {
                        var users = new HashSet<string>();
                        users.Add(forceUser);
                        if (!forceSideUsers.ContainsKey(forceSide))
                        {
                            forceSideUsers.Add(forceSide, users);
                        }
                        else
                        {
                            var oldUsers = forceSideUsers[forceSide];
                            oldUsers.Add(forceUser);
                            forceSideUsers[forceSide] = oldUsers;
                        }

                        forceUsers.Add(forceUser);
                    }
                }

                if (Regex.IsMatch(line, regexArrow))
                {
                    
                    var forceSide = Regex.Match(line, regexArrow).Groups[2].Value;
                    var forceUser = Regex.Match(line, regexArrow).Groups[1].Value;
                    
                    if (!forceUsers.Contains(forceUser))
                    {
                        var users = new HashSet<string>();
                        users.Add(forceUser);
                        if (!forceSideUsers.ContainsKey(forceSide))
                        {
                            forceSideUsers.Add(forceSide, users);
                        }
                        else
                        {
                            var oldUsers = forceSideUsers[forceSide];
                            oldUsers.Add(forceUser);
                            forceSideUsers[forceSide] = oldUsers;
                        }

                    }
                    else
                    {
                        /*
                     you should check if there is such forceUser already and if so, 
                     change his/her side. If there is no such forceUser, 
                     add him/her to the corresponding forceSide, 
                     treating the command as new registered forceUser.
                    Then you should print on the console: "{forceUser} joins the {forceSide} side!" 
                    */
                        var oldForceSide = forceSideUsers.Where(f => f.Value.Contains(forceUser)).Select(f => f.Key).First();
                        var oldUsers = forceSideUsers[oldForceSide];
                        oldUsers.Remove(forceUser);
                        forceSideUsers[oldForceSide] = oldUsers;
                        if (!forceSideUsers.ContainsKey(forceSide))
                        {
                            var set = new HashSet<string>();
                            set.Add(forceUser);
                            forceSideUsers.Add(forceSide, set);
                        }
                        else
                        {
                            var old = forceSideUsers[forceSide];
                            old.Add(forceUser);
                            forceSideUsers[forceSide] = old;
                        }
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                line = Console.ReadLine();
            }

            //print each force side, ordered descending by forceUsers count, 
            //than ordered by name. For each side print the forceUsers, ordered by name.
            //In case there are no forceUsers in a side, you shouldn`t print the side information.
            var sorted = forceSideUsers.OrderByDescending(f => f.Value.Count()).ThenBy(f => f.Key).Where(f => f.Value.Count() > 0);
            foreach (var side in sorted)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
                var users = side.Value.OrderBy(u => u).ToArray();
                Console.WriteLine(string.Join(Environment.NewLine, users.Select(u => $"! {u}")));
            }
        }
    }
}
