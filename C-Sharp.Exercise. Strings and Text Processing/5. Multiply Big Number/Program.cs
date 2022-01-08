using System;
using System.Collections.Generic;

namespace _5._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string textNumber = Console.ReadLine();
            decimal num = decimal.Parse(Console.ReadLine());

            string finalSum = "";
            decimal reminder = 0;
            for (int i = textNumber.Length-1; i >=0; i--)
            {
                decimal number = (decimal)char.GetNumericValue(textNumber[i]);
                decimal multiNumber = number * num + reminder ;
                string multiNum = Convert.ToString(multiNumber);
                if (multiNumber >= 10 && i != 0)
                {
                    finalSum += multiNum[1];
                    reminder = (decimal)char.GetNumericValue(multiNum[0]);
                }
                else if (i != 0 && multiNumber < 10)
                {
                    finalSum += multiNum;
                    reminder = 0;
                }
                if (i==0)
                {
                    char[] charNumber = multiNum.ToCharArray();
                    Array.Reverse(charNumber);
                    finalSum += new string(charNumber);
                }
            }

            char[] finalWordChar = finalSum.ToCharArray();
            Array.Reverse(finalWordChar);
            if (finalWordChar[0]=='0'&&finalWordChar.Length>1)
            {
                List<char> newChar = new List<char>();
                foreach (char c in finalWordChar)
                {
                    newChar.Add(c);
                }
                while (newChar[0]=='0'&&newChar.Count>1)
                {
                    newChar.Remove('0');
                }
                string finalWord = "";
                foreach (char c in newChar)
                {
                    finalWord += c;
                }
                Console.WriteLine(new string(finalWord));
            }
            else
            {
            string finalWord = new string(finalWordChar);
            Console.WriteLine(new string (finalWord));
            }
        }
    }
}
