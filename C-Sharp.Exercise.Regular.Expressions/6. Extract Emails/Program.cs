using System;
using System.Text.RegularExpressions;
namespace _6._Extract_Emails
{
    class Program
    {
        //33/100
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
             MatchCollection matches = Regex.Matches(text, @"(^|\s)([A-Za-z0-9][\w.,-]*)\@([a-zA-z]+([.][a-zA-z-]+)*)");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
