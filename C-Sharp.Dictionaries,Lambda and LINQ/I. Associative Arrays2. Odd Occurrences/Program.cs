using System;
using System.Collections.Generic;
using System.Linq;

namespace I._Associative_Arrays2._Odd_Occurrences
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] wordsArr = Console.ReadLine().Split(' ');

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string word in wordsArr)
            {
                string wordToLower = word.ToLower();
                if (!wordsCount.ContainsKey(wordToLower))
                {
                    wordsCount.Add(wordToLower, 0);
                }
                wordsCount[wordToLower]++;
            }
            wordsCount = wordsCount.Where(x => x.Value % 2 != 0).ToDictionary(x=>x.Key, x=>x.Value);

            Console.WriteLine(string.Join(" ",wordsCount.Keys));
        }
    }
}
