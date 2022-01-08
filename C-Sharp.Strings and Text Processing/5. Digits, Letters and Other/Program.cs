using System;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charText = text.ToCharArray();
            for (int i = 0; i < charText.Length; i++)
            {
                if (char.IsDigit(charText[i]))
                {
                    Console.Write(charText[i]);
                }
            }


            Console.WriteLine();
            for (int i = 0; i < charText.Length; i++)
            {
                if (char.IsLetter(charText[i]))
                {
                    Console.Write(charText[i]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < charText.Length; i++)
            {
                if (!char.IsLetterOrDigit(charText[i]))
                {
                    Console.Write(charText[i]);
                }
            }
            
        }
    }
}
