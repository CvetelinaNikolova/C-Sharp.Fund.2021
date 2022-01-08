using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _2.Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string text = Console.ReadLine();
                string regex = @"^(?<S>[$%])(?<tag>[A-Z][a-z]{2,})\k<S>: [[](?<N1>[0-9]+)[]][|][[](?<N2>[0-9]+)[]][|][[](?<N3>[0-9]+)[]][|]$";
                Match match = Regex.Match(text, regex);
                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    int n1 = Convert.ToInt32(match.Groups["N1"].Value);
                    char N1 = (char)n1;
                    int n2 = Convert.ToInt32(match.Groups["N2"].Value);
                    char N2 = (char)n2;
                    int n3 = Convert.ToInt32(match.Groups["N3"].Value);
                    char N3 = (char)n3;

                    Console.WriteLine($"{tag}: {N1}{N2}{N3}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
