using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }
        public static void CheckNumber(int num)
        {
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num==0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
