using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            int[] revNumbers = new int[num];
            int count = 0;
            for (int i = num-1; i >= 0; i--)
            {
                revNumbers[i] = numbers[count];
                count++;
            }
            int j = 0;
            foreach (int number in revNumbers)
            {
                Console.Write($"{revNumbers[j]} ");
                j++;
            }
        }
    }
}
