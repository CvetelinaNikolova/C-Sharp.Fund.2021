using System;

namespace _4._Refactoring.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                bool isPrime = true;
                int count = 0;
                for (int j = 2; j <= range; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count>=2)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string result = "";
                if (isPrime==false)
                {
                    result = "false";
                }
                else
                {
                    result = "true";
                }
                Console.WriteLine("{0} -> {1}", i, result);
            }
        }
    }
}
