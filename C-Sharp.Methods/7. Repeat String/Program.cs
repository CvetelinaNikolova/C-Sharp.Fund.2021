using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string theString = Console.ReadLine();
            int repetition = int.Parse(Console.ReadLine());

            GetString(theString, repetition);
        }
        static void GetString(string text, int repetition)
        {
            for (int i = 0; i < repetition; i++)
            {
                Console.Write(text);
            }
        }
    }
}
