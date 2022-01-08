using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"((^\+)| \+)359( |-)2\3[0-9]{3}\3[0-9]{4}\b");

            var finalMatches = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", finalMatches));
        }
    }
}
