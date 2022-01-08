using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintingTriangle(num);
        }
        public static void PrintingTriangle(int num)
        {
            for (int i = 1;  i<= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");
            }
            for (int i = num-1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");
            }
        }
    }
}
