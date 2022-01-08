using System;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word!="end")
            {
                char[] charWord = word.ToCharArray();
                Array.Reverse(charWord);
                string reversedWord = new string(charWord);
                Console.WriteLine($"{word} = {reversedWord}");
                word = Console.ReadLine();
            }
        }
    }
}
