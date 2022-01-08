using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _2___Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"(?<S>=|\/)(?<loc>[A-Z][A-Za-z]{2,})\k<S>";
            MatchCollection matches = Regex.Matches(text, regex);

            List<string> destinations = new List<string>();
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                string destination = match.Groups["loc"].ToString();
                int points = destination.Length;

                destinations.Add(destination);
                travelPoints += points;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
