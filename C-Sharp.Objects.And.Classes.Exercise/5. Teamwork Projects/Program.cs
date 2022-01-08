using System;
using System.Collections.Generic;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists lists = new Lists();
            lists.TeamsList = new List<Teams>();
            lists.CreatorsList = new List<Users>();

            int numberOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] command = Console.ReadLine().Split("-");
                bool haveUserName = false;
                bool haveTeamName = false;

                Teams team = new Teams();
                team.TeamName = command[1];
                team.Users = new List<Users>();
                if (lists.TeamsList.Count > 0)
                {
                    foreach (Teams Team in lists.TeamsList)
                    {
                        if (Team.TeamName == team.TeamName)
                        {
                            Console.WriteLine($"Team {team.TeamName} was already created!");
                            haveTeamName = true;
                        }
                    }
                }

                Users user = new Users();
                user.UserName = command[0];
                if (lists.CreatorsList.Count > 0)
                {

                    foreach (Users User in lists.CreatorsList)
                    {
                        if (User.UserName == user.UserName)
                        {
                            Console.WriteLine($"{user.UserName} cannot create another team!");
                            haveUserName = true;
                        }
                    }
                }

                if (haveTeamName || haveUserName)
                {
                    continue;
                }

                team.Users.Add(user);
                lists.CreatorsList.Add(user);
                lists.TeamsList.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {user.UserName}");
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] command = input.Split("->");
                bool haveTeam = false;
                bool haveUser = false;

                Users user = new Users();
                user.UserName = command[0];

                string teamName = command[1];

                foreach (Teams team in lists.TeamsList)
                {
                    foreach (Users User in team.Users)
                    {
                        if (User.UserName == user.UserName)
                        {
                            haveUser = true;
                        }
                    }
                }
                if (haveUser)
                {
                    Console.WriteLine($"Member {user.UserName} cannot join team {teamName}");
                }

                foreach (Teams team in lists.TeamsList)
                {
                    if (team.TeamName == teamName)
                    {
                        if (haveUser == false)
                        {
                            team.Users.Add(user);
                        }
                        haveTeam = true;
                        break;
                    }
                }
                if (haveTeam == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                input = Console.ReadLine();
            }

            Teams[] teamsArr = lists.TeamsList.ToArray();

            Array.Sort(teamsArr, OrberByCountOfUsers);

            foreach (Teams team in lists.TeamsList)
            {
                team.users = team.Users.ToArray();
                Array.Sort(team.users, OrderByName);
            }

            foreach (Teams team in lists.TeamsList)
            {
                Console.WriteLine($"{team.TeamName}");
                for (int i = 0; i < team.users.Length; i++)
                {
                    if (i==0)
                    {
                        Console.WriteLine($"-{team.users[i].UserName}");
                    }
                    else
                    {
                        Console.WriteLine($"--{team.users[i].UserName}");
                    }
                }
            }
            
            
        }
        static int OrberByCountOfUsers(Teams team1, Teams team2)
        {
            return team2.Users.Count.CompareTo(team1.Users.Count);
        }
        static int OrderByName(Users user1, Users user2)
        {
            return user1.UserName.CompareTo(user2.UserName);
        }
    }
}
