using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] myChar = input.ToCharArray();
            Array.Reverse(myChar);
            Console.WriteLine(myChar);
        }
    }
}
