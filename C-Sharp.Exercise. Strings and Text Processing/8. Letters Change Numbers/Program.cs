using System;
using System.Collections.Generic;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> textList = new List<char>();
            char lastChar = new char();
            foreach (char c in text)
            {
                if (lastChar==' '&&c==' ')
                {
                    lastChar = ' ';
                    continue;
                }
                lastChar = c;
                textList.Add(c);
            }
            
            string[] strings = string.Join("",textList).Split(' ');

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            decimal finalResult = 0;

            foreach (string str in strings)
            {
                char firstLetter = str[0];
                char lastLetter = str[str.Length - 1];
                string num = "";
                for (int i = 1; i <= str.Length-2; i++)
                {
                    num += str[i];
                }
                decimal number = Convert.ToDecimal(num);

                decimal thisStringNumber = 0;
                if (char.IsUpper(firstLetter))
                {
                    decimal position = alphabet.IndexOf(char.ToLower(firstLetter))+1;

                    thisStringNumber = number / position;
                }
                else
                {
                    decimal position = alphabet.IndexOf(char.ToLower(firstLetter))+1;

                    thisStringNumber = number * position;
                }

                if (char.IsUpper(lastLetter))
                {
                    decimal position = alphabet.IndexOf(char.ToLower(lastLetter))+1;

                    thisStringNumber -= position;
                }
                else
                {
                    decimal position = alphabet.IndexOf(char.ToLower(lastLetter))+1;

                    thisStringNumber += position;
                }

                finalResult += thisStringNumber;
            }
            Console.WriteLine($"{finalResult:f2}");
        }
    }
}
