using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;


namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split("|");
            string Part1 = parts[0];
            string Part2 = parts[1];
            string Part3 = parts[2];

            Dictionary<string, int> info = new Dictionary<string, int>();

            List<string> words = new List<string>();

            string regex1 = @"(?<S>[#$%*&])(?<P1>[A-Z]+)\k<S>";
            Match P1 = Regex.Match(Part1, regex1);
            string letters = P1.Groups["P1"].Value;
            foreach (char c in letters)
            {
                if (!info.ContainsKey(c.ToString()))
                {
                    info.Add(c.ToString(), 0);
                }
            }

            for (int i = 0; i < info.Count; i++)
            {
                var letter = info.ElementAt(i);
                int code = (int)Convert.ToChar(letter.Key);
                string regex2 = $"({code}):(?<lenght>[0-9]{{{2}}})";
                Match P2 = Regex.Match(Part2, regex2);
                int lenght = int.Parse(P2.Groups["lenght"].Value);
                info[letter.Key] = lenght;
            }

            for (int i = 0; i < info.Count; i++)
            {
                var pair = info.ElementAt(i);
                string letter = pair.Key;
                int lenght = pair.Value;

                string regex3 = $"([ ]|^)({letter})[^ ]{{{lenght}}}([ ]|$)";
                Match P3 = Regex.Match(Part3, regex3);

                if (P3.Success)
                {
                    words.Add(P3.Value.Trim());
                }
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
