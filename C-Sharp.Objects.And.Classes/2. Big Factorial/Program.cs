using System;
using System.Numerics;

namespace _2._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger finalSum = new BigInteger(number); 
            for (int i = number-1; i >0; i--)
            {
                finalSum *= i;
            }
            Console.WriteLine(finalSum);
        }
    }
}
