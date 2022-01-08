using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal pow = decimal.Parse(Console.ReadLine());
            MathPower(num, pow);
        }
        static void MathPower(decimal number, decimal pow)
        {
            decimal numForPow = number;
            for (int i = 1; i < pow; i++)
            {
                decimal num = numForPow*number;
                number = num;
                
            }
            Console.WriteLine($"{number}");
        }
    }
}
