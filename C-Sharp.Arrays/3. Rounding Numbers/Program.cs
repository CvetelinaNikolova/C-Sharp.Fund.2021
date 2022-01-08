using System;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            decimal[] numbers = new decimal[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = Convert.ToDecimal(input[i]);
            }

            int[] intNumbers = new int[numbers.Length];

            for (int i = 0; i < intNumbers.Length; i++)
            {
                intNumbers[i] = (int)Math.Round(numbers[i],MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {intNumbers[i]}");
            }
        }
    }
}
