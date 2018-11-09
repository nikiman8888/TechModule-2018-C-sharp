using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] current = Console.ReadLine().Split('-');

                string user = current[0];
                string teamName = current[1];
                

                var currentTeam = new Team(user, teamName, new List<string>());

                if (teams.Any(x=>x.UserCreator == user) || teams.Any(x=>x.TeamName == teamName))
                {
                    

                    if (teams.Any(x => x.TeamName == teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    else
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                    }
                }
                else
                {

                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                    currentTeam.UserCreator = user;

                    teams.Add(currentTeam);
                }

            }
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] tokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string userToJoin = tokens[0];
                string teamToJoin = tokens[1];

                bool noneExistTeam = false;
                bool existUser = false;

                if (!ExistTeam(teamToJoin,teams))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    noneExistTeam = true;
                }
                 else if (ExistUser(userToJoin,teams))
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                    existUser = true;
                }
                if (!noneExistTeam && !existUser)
                {
                    foreach (var team in teams.Where(x=>x.TeamName == teamToJoin))
                    {
                        team.Users.Add(userToJoin);
                        break;
                    }
                }
                
                input = Console.ReadLine();
            }
            foreach (var team in teams
                .Where(x=>x.Users.Count > 0)
                .OrderByDescending(x=>x.Users.Count)
                .ThenBy(x=>x.TeamName))
            {
                Console.WriteLine(team.TeamName);

                Console.WriteLine("- {0}",team.UserCreator);

                foreach (var name in team.Users.OrderBy(x=>x))
                {                   
                    Console.WriteLine("-- {0}",name);
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(x=>x.Users.Count == 0).OrderBy(x=>x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }

        private static bool ExistUser(string user   , List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Users.Contains(user) || team.UserCreator == user)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ExistTeam(string teamToJoin, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == teamToJoin )
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Team
    {
        public string UserCreator { get; set; }
        public string TeamName { get; set; }

        public List<string> Users { get; set; }

        public Team (string user,string teamName, List<string > users)
        {
            UserCreator = user;
            TeamName = teamName;
            Users = users;
        }
    }
}
