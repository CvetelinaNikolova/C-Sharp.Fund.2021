using System;
using System.Collections.Generic;

namespace _1.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings =Console.ReadLine().Split(' ');
            var rand = new Random();
            string[] newString = new string[strings.Length];
            int count = 0;
            List<int> indexes = new List<int>();
            while (count<=newString.Length-1)
            {
                int num = rand.Next(0, strings.Length);
                if (indexes.Contains(num)==false)
                {
                    newString[count] = strings[num];
                    indexes.Add(num);
                    count++;
                }
            }
            foreach (string str in newString)
            {
                Console.WriteLine(str);
            }
        }

        
    }
}
