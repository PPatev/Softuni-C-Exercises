using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Teamwork_projects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split('-');
                var creator = input[0];
                var teamName = input[1];
                if (teams.Select(t => t.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Select(t => t.Creator).Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                var team = new Team();
                team.Creator = creator;
                team.Name = teamName;
                team.Memebers = new List<string>();
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
                teams.Add(team);
            }

            var line = Console.ReadLine();
            while (line != "end of assignment")
            {
                var input = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var user = input[0];
                var teamName = input[1];
                if (!teams.Select(t => t.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    line = Console.ReadLine();
                    continue;
                }

                var teamMembers = teams.Select(t => t.Memebers).Select(t => t.Contains(user));
                if (!teamMembers.All(c => c == false) || teams.Select(t => t.Creator).Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    line = Console.ReadLine();
                    continue;
                }

                teams.Where(t => t.Name.Equals(teamName)).First().Memebers.Add(user);
                line = Console.ReadLine();
            }

            var validTeams = teams.Where(t => t.Memebers.Count > 0).OrderByDescending(t => t.Memebers.Count).ThenBy(t => t.Name);
            foreach (var team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Memebers.OrderBy(m => m).Select(m => $"-- {m}")));
            }

            Console.WriteLine("Teams to disband:");
            var disboundTeams = teams.Where(t => t.Memebers.Count == 0).Select(t => t.Name).OrderBy(t => t);
            if (disboundTeams != null)
            {
                Console.WriteLine(string.Join(Environment.NewLine, disboundTeams));
            }
            
        }
    }

    class Team
    {
        public List<string> Memebers { get; set; }
        public string Creator { get; set; }
        public string Name { get; set; }
    }
}
