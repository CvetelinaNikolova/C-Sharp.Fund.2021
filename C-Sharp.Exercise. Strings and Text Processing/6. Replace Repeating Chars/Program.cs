using System;
using System.Collections.Generic;

namespace _6._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> charText = new List<char>();

            char lastChar = text[0];
            charText.Add(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (lastChar!=text[i])
                {
                    charText.Add(text[i]);
                }
                lastChar = text[i];
            }

            string finalWord = "";
            foreach (char c in charText)
            {
                finalWord += c;
            }

            Console.WriteLine(finalWord);
        }
    }
}
