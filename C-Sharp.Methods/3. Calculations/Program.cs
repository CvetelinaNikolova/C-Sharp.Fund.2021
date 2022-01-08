using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Substract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;

                default:
                    break;
            }
        }

        public static void Add(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            Console.WriteLine(result);
        }

        public static void Multiply(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            Console.WriteLine(result);
        }

        public static void Substract(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            Console.WriteLine(result);
        }

        public static void Divide(decimal num1, decimal num2)
        {
            decimal result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
