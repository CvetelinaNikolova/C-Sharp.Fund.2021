using System;
using System.Collections.Generic;
using System.Linq;

namespace I._Associative_Arrays._3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymsPairs = new Dictionary<string, List<string>>();

            int numberOfPair = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPair; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonymsPairs.ContainsKey(word))
                {
                    synonymsPairs.Add(word, new List<string>());
                }
                synonymsPairs[word].Add(synonym);
            }

            foreach (var pair in synonymsPairs)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}
