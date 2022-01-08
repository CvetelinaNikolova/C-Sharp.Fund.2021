using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();

            Dictionary<char, int> countChar = new Dictionary<char, int>();

            foreach (char c in charArr)
            {
                if (c!=' ')
                {
                    if (!countChar.ContainsKey(c))
                    {
                        countChar.Add(c, 0);
                    }
                    countChar[c]++;
                }
            }

            foreach (var pair in countChar)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
