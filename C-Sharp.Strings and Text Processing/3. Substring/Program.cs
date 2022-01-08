using System;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string finalWord = Console.ReadLine();
            while (finalWord.Contains(wordToRemove))
            {
                int index = finalWord.IndexOf(wordToRemove);
                finalWord = finalWord.Remove(index, wordToRemove.Length);
            }
            Console.WriteLine(finalWord);
        }
    }
}
