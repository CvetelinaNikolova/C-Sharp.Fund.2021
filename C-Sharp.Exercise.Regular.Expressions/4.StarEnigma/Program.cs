using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlanets = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfPlanets; i++)
            {
                string regex = @"@(?<name>[A-z]+)[^@\-:!>]*:(?<population>[\d]+)[^@\-:!>]*!(?<attackType>[AD])![^@\-:!>]*->(?<soldierCount>[\d]+)";
                string message = Console.ReadLine();

                int remove = 0;

                string lowerMessage = message.ToLower();
                foreach (char c in lowerMessage)
                {
                    if (c=='s'||c=='t'||c=='a'||c=='r')
                    {
                        remove++;
                    }
                }
                string decryptedMessage = "";
                foreach (char c in message)
                {
                    decryptedMessage += (char)(c - remove);
                }

                Match match = Regex.Match(decryptedMessage, regex, RegexOptions.IgnoreCase);

                string name = match.Groups["name"].Value;
                string attackType = match.Groups["attackType"].Value;

                if (attackType=="A")
                {
                    attackedPlanets.Add(name);
                }
                else if (attackType=="D")
                {
                    destroyedPlanets.Add(name);
                }

            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            destroyedPlanets.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
        }
    }
}
