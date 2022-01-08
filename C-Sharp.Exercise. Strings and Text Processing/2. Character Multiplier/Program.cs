using System;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string word1 = strings[0];
            string word2 = strings[1];
            bool word1IsShorter = false;
            bool word2IsShorter = false;

            decimal finalSum = 0;
            if (word1.Length>=word2.Length)
            {
                word2IsShorter = true;
            }
            else
            {
                word1IsShorter = true;
            }

            if (word1IsShorter)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    decimal number = word1[i] * word2[i];
                    finalSum += number;
                }
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    decimal number = word2[i];
                    finalSum += number;
                }
            }
            else if (word2IsShorter)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    decimal number = word1[i] * word2[i];
                    finalSum += number;
                }
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    decimal number = word1[i];
                    finalSum += number;
                }
            }
            Console.WriteLine(finalSum);
        }
    }
}
