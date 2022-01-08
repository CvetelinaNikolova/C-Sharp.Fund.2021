using System;
using System.Linq;
using System.Collections.Generic;

namespace _3___Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> plantsRarity = new Dictionary<string, decimal>();

            Dictionary<string, List<decimal>> plantsRating = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < number; i++)
            {
                string[] info = Console.ReadLine().Split("<->");
                string name = info[0];
                decimal rarity = decimal.Parse(info[1]);

                if (!plantsRarity.ContainsKey(name))
                {
                    plantsRarity.Add(name, rarity);
                    List<decimal> ratings = new List<decimal>();
                    plantsRating.Add(name, ratings);
                }
                else
                {
                    plantsRarity[name] = rarity;
                }
            }

            string input = Console.ReadLine();
            while (input!="Exhibition")
            {
                string[] info = input.Split(":");
                string command = info[0];
                if (command=="Rate")
                {
                    string name = info[1].Split("-").ElementAt(0).Trim();
                    decimal rating = decimal.Parse(info[1].Split("-").ElementAt(1).Trim());

                    if (!plantsRating.ContainsKey(name))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        plantsRating[name].Add(rating);
                    }
                }
                else if (command=="Update")
                {
                    string name = info[1].Split("-").ElementAt(0).Trim();
                    decimal rarity = decimal.Parse(info[1].Split("-").ElementAt(1).Trim());

                    if (plantsRarity.ContainsKey(name))
                    {
                        plantsRarity[name] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if(command=="Reset")
                {
                    string name = info[1].Trim();

                    if (plantsRating.ContainsKey(name))
                    {
                        while (plantsRating[name].Count>0)
                        {
                            plantsRating[name].Remove(plantsRating[name][0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                input = Console.ReadLine();
            }

            Dictionary<string, List<decimal>> plantsInfo = new Dictionary<string, List<decimal>>();

            foreach (var item in plantsRarity)
            {
                string name = item.Key;
                if (!plantsInfo.ContainsKey(name))
                {
                    decimal rating = 0;
                    foreach (var num in plantsRating[name])
                    {
                        rating += num;
                    }

                    decimal avRating = 0;
                    if (plantsRating[name].Count>0)
                    {
                        avRating = rating / (decimal)plantsRating[name].Count;
                    }

                    decimal rarity = item.Value;

                    List<decimal> info = new List<decimal>()
                    {
                        rarity,
                        avRating
                    };

                    plantsInfo.Add(name, info);
                }
            }

            var sorted = plantsInfo.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]);
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var item in sorted)
            {
                string name = item.Key;
                decimal rarity = item.Value[0];
                decimal rating = item.Value[1];
                Console.WriteLine($"- {name}; Rarity: {rarity}; Rating: {rating:f2}");
            }
        }
    }
}
