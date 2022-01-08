using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            decimal result = Calculate(number1, @operator, number2);
            Console.WriteLine(result);
        }
        static decimal Calculate (int num1, string @operator, int num2)
        {
            decimal result = 0;
            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result =(decimal)num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
