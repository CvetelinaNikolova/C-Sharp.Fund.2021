using System;

namespace _4._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = Convert.ToChar(text[i] + 3);
                newText += c;
            }
            Console.WriteLine(newText);
        }
    }
}
