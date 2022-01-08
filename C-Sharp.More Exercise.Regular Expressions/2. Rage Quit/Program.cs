using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<text>[\D]+)(?<number>[\d]+)";
            string text = Console.ReadLine();
            StringBuilder finalWord = new StringBuilder();
            HashSet<char> symbols = new HashSet<char>();

            MatchCollection matches = Regex.Matches(text, regex);

            foreach (Match match in matches)
            {
                string message = match.Groups["text"].ToString().ToUpper();
                int number = Convert.ToInt32(match.Groups["number"].ToString());
                if (number>0)
                {
                    foreach (char c in message)
                    {
                        symbols.Add(c);
                    }
                }

                for (int i = 0; i < number; i++)
                {
                    finalWord.Append(message);
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(finalWord.ToString());
        }
    }
}
