using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);
            long result = GetMultipleOfEvenAndOdd(sumOfEven, sumOfOdd);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int result=0;
            while (Math.Abs(number)>0)
            {
                int num = Math.Abs(number % 10);
                if (num%2==0)
                {
                  result += num;
                }
                number /= 10;
            }
            return result;
        }
        static int GetSumOfOddDigits(int number)
        {
            int result = 0;
            while (Math.Abs(number)>0)
            {
                int num =Math.Abs(number % 10);
                if (num%2!=0)
                {
                    result += num;
                }
                number /= 10;
            }
            return result;
        }
        static long GetMultipleOfEvenAndOdd(int even,int odd)
        {
            long result = even * odd;

            return result;
        }
    }
}
