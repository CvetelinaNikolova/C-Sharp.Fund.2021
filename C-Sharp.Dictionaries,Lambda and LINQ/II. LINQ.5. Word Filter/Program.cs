using System;
using System.Collections.Generic;
using System.Linq;

namespace II._LINQ._5._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                 .Split(" ");
            Dictionary<string, int> charsCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!charsCounts.ContainsKey(word))
                {
                    char[] charCount = word.ToCharArray();
                    charsCounts.Add(word, charCount.Length);
                }
            }

            charsCounts = charsCounts.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);
            foreach (var word in charsCounts)
            {
                Console.WriteLine(word.Key);
            }
        }
    }
}
