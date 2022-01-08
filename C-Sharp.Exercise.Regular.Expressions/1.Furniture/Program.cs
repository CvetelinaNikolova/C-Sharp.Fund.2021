using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Match> matches = new List<Match>();

            string input = Console.ReadLine();
            while (input!="Purchase")
            {
                Match match = Regex.Match(input, @">{2}(?<name>[A-za-z][A-Za-z]+)<{2}(?<price>[0-9]+([.][0-9]+)?)!(?<quantity>[0-9]+)");
                if (match.Success)
                {
                    matches.Add(match);
                }
                input = Console.ReadLine();
            }

            decimal finalPrice = 0;
            Console.WriteLine($"Bought furniture:");
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].ToString();
                decimal moneyForThis = Convert.ToDecimal(match.Groups["price"].ToString()) * Convert.ToDecimal(match.Groups["quantity"].ToString());
                Console.WriteLine($"{name}");
                finalPrice += moneyForThis;
            }
            Console.WriteLine($"Total money spend: {finalPrice:f2}");
        }
    }
}
