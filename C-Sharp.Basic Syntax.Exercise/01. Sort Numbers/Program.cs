using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int firstNumber = int.MinValue;
            int thirdNumber = int.MaxValue;
            int secondNumber = 0;
            if (num1 > firstNumber)
            {
                firstNumber = num1;
            }
            if (num2 > firstNumber)
            {
                firstNumber = num2;
            }
            if (num3 > firstNumber)
            {
                firstNumber = num3;
            }


            if (num1 < thirdNumber)
            {
                thirdNumber = num1;
            }
            if (num2 < thirdNumber)
            {
                thirdNumber = num2;
            }
            if (num3 < thirdNumber)
            {
                thirdNumber = num3;
            }

            if ((num1 == firstNumber || num1 == thirdNumber) && (num3 == firstNumber || num3 == thirdNumber))
            {
                secondNumber = num2;
            }
            if ((num2 == firstNumber || num2 == thirdNumber) && (num3 == firstNumber || num3 == thirdNumber))
            {
                secondNumber = num1;
            }
            if ((num1 == firstNumber || num1 == thirdNumber) && (num2 == firstNumber || num2 == thirdNumber))
            {
                secondNumber = num3;
            }
            Console.WriteLine($"{firstNumber}");
            Console.WriteLine($"{secondNumber}");
            Console.WriteLine($"{thirdNumber}");
        }
    }
}
