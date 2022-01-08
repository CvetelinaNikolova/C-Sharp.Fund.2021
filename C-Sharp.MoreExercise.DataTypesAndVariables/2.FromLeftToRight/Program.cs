using System;

namespace _2.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] strings = (Console.ReadLine()).Split(' ');

                long num1 = Convert.ToInt64(strings[0]);
                long num2 = Convert.ToInt64(strings[1]);

                long tempNum1 = Math.Abs(num1);
                long tempNum2 = Math.Abs(num2);

                long sum1 = 0;
                long sum2 = 0;

                while (tempNum1>0)
                {
                    long num = tempNum1 % 10;
                    sum1 += num;
                    tempNum1 /= 10;
                }

                while (tempNum2 > 0)
                {
                    long num = tempNum2 % 10;
                    sum2 += num;
                    tempNum2 /= 10;
                }
                if (num1>=num2)
                {
                    Console.WriteLine(sum1);
                }
                else
                {
                    Console.WriteLine(sum2);
                }
            }
        }
    }
}
