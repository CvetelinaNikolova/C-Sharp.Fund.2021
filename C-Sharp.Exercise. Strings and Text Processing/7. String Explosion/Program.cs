using System;
using System.Collections.Generic;

namespace _7._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> charText = new List<char>();
            int reminder = 0;
            int currIndex = 0;
            bool tooLong = false;
            for (int i = 0; i < text.Length; i++)
            {
                bool looped = false;
                if (text[i]!='>')
                {
                    charText.Add(text[i]);
                }
                else if (text[i]=='>')
                {
                    charText.Add(text[i]);
                    int power = (int)char.GetNumericValue(text[i + 1]) + reminder;
                    for (int j = i+1; j <=i+power; j++)
                    {
                        looped = true;
                        if (j>text.Length-1)
                        {
                            tooLong = true;
                            break;
                        }
                        if (text[j]=='>')
                        {
                            reminder = (i + power) - (j - 1);
                            currIndex = j-1;
                            break;
                        }
                        currIndex = j;
                    }
                    if (tooLong)
                    {
                        break;
                    }
                    if (looped)
                    {
                        i = currIndex;
                    }
                }
            }
            Console.WriteLine(string.Join("", charText));
        }
    }
}
