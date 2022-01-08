using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            int left = 0;
            string evenOrOdd = "";
                switch (operation)
            {
                case "+":
                    result = N1 + N2;
                    break;
                case "-":
                    result = N1 - N2;
                    break;
                case "*":
                    result = N1 * N2;
                    break;
                case "/":
                    double num1 = N1;
                    double num2 = N2;
                    result = num1 / num2;
                    break;
                case "%":
                    try
                    {
                        left = N1 % N2;
                    }
                    
            }
            if((operation == "+")||(operation == "-")||(operation == "*"))
            {
                if(result%2==0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenOrOdd}");
            }
            if (operation == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
                }
            }
            if (operation == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} {operation} {N2} = {left}");
                }
            }
        }
    }
}
