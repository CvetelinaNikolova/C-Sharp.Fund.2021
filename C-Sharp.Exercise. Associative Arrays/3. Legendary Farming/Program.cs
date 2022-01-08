using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> legendaryPieces = new Dictionary<string, decimal>()
            {
                {"shards",0},
                {"fragments",0},
                {"motes",0}
            };

            SortedDictionary<string, decimal> junkPieces = new SortedDictionary<string, decimal>();

            bool legendaryItemObtained = false;
            string legendaryItem = "";

            while (!legendaryItemObtained)
            {
                foreach (var pair in legendaryPieces)
                {
                    if (pair.Value>=(decimal)250)
                    {
                        legendaryItemObtained = true;
                        if (pair.Key=="shards")
                        {
                            legendaryPieces["shards"] -= 250;
                            legendaryItem = "Shadowmourne";
                        }
                        else if (pair.Key == "fragments")
                        {
                            legendaryPieces["fragments"] -= 250;
                            legendaryItem = "Valanyr";
                        }
                        else if (pair.Key == "motes")
                        {
                            legendaryPieces["motes"] -= 250;
                            legendaryItem = "Dragonwrath";
                        }
                        break;
                    }
                }
                if (legendaryItemObtained)
                {
                    break;
                }

                string[] materials = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < materials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        string materialToLower = materials[i + 1].ToLower();

                        if (materialToLower == "motes" || materialToLower == "shards" || materialToLower == "fragments")
                        {
                            legendaryPieces[materialToLower] += Convert.ToDecimal(materials[i]);
                            if (legendaryPieces[materialToLower] >= 250)
                            {
                                break;
                            }
                        }


                        if (materialToLower != "motes" && materialToLower != "shards" && materialToLower != "fragments")
                        {
                            if (!junkPieces.ContainsKey(materialToLower))
                            {
                                junkPieces.Add(materialToLower, Convert.ToDecimal(materials[i]));
                            }
                            else if (junkPieces.ContainsKey(materialToLower))
                            {
                                junkPieces[materialToLower] += Convert.ToDecimal(materials[i]);
                            }
                        }
                    }
                }
            }

            legendaryPieces = legendaryPieces.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var pair in legendaryPieces)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junkPieces)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
