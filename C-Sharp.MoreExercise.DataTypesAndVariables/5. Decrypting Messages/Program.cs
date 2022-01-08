using System;

namespace _5._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < count; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int intChar = Convert.ToInt32(character);
                int intFinalChar = intChar + key;
                char finalChar = (char)intFinalChar;
                message = message + finalChar;
            }
            Console.WriteLine(message);
        }
    }
}
