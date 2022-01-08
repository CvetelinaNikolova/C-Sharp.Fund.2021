using System;
using System.Collections.Generic;

namespace WorkHere
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
