using System;
using System.Collections.Generic;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfNumbers = int.Parse(Console.ReadLine());
            List<int> digitLenght = new List<int>();
            List<int> mainDigit = new List<int>();
            for (int i = 0; i < NoOfNumbers; i++)
            {
                string input = Console.ReadLine();
                char[] myChar = input.ToCharArray();
                mainDigit.Add((int)Char.GetNumericValue(myChar[0]));
                digitLenght.Add(input.Length);
            }
            List<int> startNumber = new List<int>();
            for (int i = 0; i < mainDigit.Count; i++)
            {
                if (mainDigit[i] == 0)
                {
                    startNumber.Add(-1);
                    continue;
                }
                int strNumber = (mainDigit[i] - 2) * 3;
                if (mainDigit[i] == 8 || mainDigit[i] == 9)
                {
                    strNumber += 1;
                }
                startNumber.Add(strNumber);

            }
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<int> index = new List<int>();
            for (int i = 0; i < startNumber.Count; i++)
            {
                if (startNumber[i] == -1)
                {
                    index.Add(-1);
                    continue;
                }
                int idx = startNumber[i] + digitLenght[i] - 1;
                index.Add(idx);
            }
            for (int i = 0; i < index.Count; i++)
            {
                if (index[i] < 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(alphabet[index[i]]);
                }
            }
        }
    }
}
