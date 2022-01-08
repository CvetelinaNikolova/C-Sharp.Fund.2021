using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input!="End")
            {
                string command = input.Split(" ").ElementAt(0);
                if (command=="Enroll")
                {
                    string name = input.Split(" ").ElementAt(1);
                    if (heroes.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(name, new List<string>());
                    }
                }
                else if (command=="Learn")
                {
                    string name = input.Split(" ").ElementAt(1);
                    string spell = input.Split(" ").ElementAt(2);
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                        else
                        {
                            heroes[name].Add(spell);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }
                else if (command=="Unlearn")
                {
                    string name = input.Split(" ").ElementAt(1);
                    string spell = input.Split(" ").ElementAt(2);
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            heroes[name].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }
                input = Console.ReadLine();
            }

            var sorted = heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            Console.WriteLine("Heroes:");
            foreach (var item in sorted)
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
