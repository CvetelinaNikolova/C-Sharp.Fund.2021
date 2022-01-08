using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            Dictionary<string, decimal> raceResults = new Dictionary<string, decimal>();
            foreach (string name in names)
            {
                raceResults.Add(name, 0);
            }

            string input = Console.ReadLine();
            
            while (input!="end of race")
            {
                MatchCollection nameMatches = Regex.Matches(input, "[A-Za-z]+");
                string name = string.Join("", nameMatches);
                string nameMatch = "";
                foreach (var racer in raceResults)
                {
                    Match match = Regex.Match(name, racer.Key);
                    if (match.Success)
                    {
                        nameMatch = match.ToString()
;                    }
                }
                if (raceResults.ContainsKey(nameMatch))
                {
                    MatchCollection numMatches = Regex.Matches(input, "[0-9]+");
                    string numbersMatch = string.Join("", numMatches);

                    decimal thisResult = 0;
                    foreach (char c in numbersMatch)
                    {
                        thisResult += (decimal)char.GetNumericValue(c);
                    }
                    raceResults[nameMatch.ToString()] += thisResult;
                }

                input = Console.ReadLine();
            }

            var finalResult = raceResults.OrderByDescending(x => x.Value);

            int placeCount = 0;

            foreach (var racer in finalResult)
            {
                placeCount++;
                if (placeCount==1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (placeCount==2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else if (placeCount==3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
