using System;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    string replaceWord = "";
                    for (int j= 0; j < bannedWords[i].Length; j++)
                    { 
                        replaceWord += "*";
                    }
                    text = text.Replace(bannedWords[i], replaceWord);
                }
            }
            Console.WriteLine(text);
        }
    }
}
