using System;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal grade = decimal.Parse(Console.ReadLine());
            CheckGrade(grade);
        }
        public static void CheckGrade(decimal num)
        {
            switch (num)
            {
                case decimal tempNum when (tempNum >= 2 && tempNum < 3):
                    Console.WriteLine("Fail");
                    break;
                case decimal tempNum when (tempNum >= 3 && tempNum < (decimal)3.5):
                    Console.WriteLine("Poor");
                    break;
                case decimal tempNum when (tempNum >= (decimal)3.5 && tempNum < (decimal)4.5):
                    Console.WriteLine("Good");
                    break;
                case decimal tempNum when (tempNum >= (decimal)4.5 && tempNum < (decimal)5.5):
                    Console.WriteLine("Very good");
                    break;
                case decimal tempNum when (tempNum >= (decimal)5.5 && tempNum < 6):
                    Console.WriteLine("Excellent");
                    break;

                default:
                    break;
            }
        }
    }
}
