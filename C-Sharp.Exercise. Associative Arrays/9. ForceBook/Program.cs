using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();
            while (input!="Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] info = input.Split(" | ");
                    string side = info[0];
                    string user = info[1];
                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers.Add(side, new List<string>());
                    }

                    if (!forceUsers[side].Contains(user) && !forceUsers.Values.Any(x => x.Contains(user)))
                    {
                        forceUsers[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] info = input.Split(" -> ");
                    string side = info[1];
                    string user = info[0];
                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers.Add(side, new List<string>());
                    }

                    if (!forceUsers[side].Contains(user) && !forceUsers.Values.Any(x => x.Contains(user)))
                    {
                        forceUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                        input = Console.ReadLine();
                        continue;
                    }


                    if (forceUsers.ContainsKey(side))
                    {
                        if (!forceUsers[side].Contains(user))
                        {
                            foreach (var list in forceUsers)
                            {
                                if (list.Value.Contains(user))
                                {

                                    list.Value.Remove(user);
                                }
                            }
                            forceUsers[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                }
                input = Console.ReadLine();
            }

            var orderedForceUsers = forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var item in orderedForceUsers)
            {
                item.Value.Sort();
                if (item.Value.Count>0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var name in item.Value)
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
            }

        }
    }
}
