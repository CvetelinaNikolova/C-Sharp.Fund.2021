using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            PriceOfOrder(product, quantity);
        }
        public static void PriceOfOrder(string product, decimal quantity)
        {
            decimal finalPriceOfOrder = 0;
            switch (product)
            {
                case "coffee":
                    finalPriceOfOrder = quantity * (decimal)1.50;
                    break;
                case "water":
                    finalPriceOfOrder = quantity * (decimal)1;
                    break;
                case "coke":
                    finalPriceOfOrder = quantity * (decimal)1.40;
                    break;
                case "snacks":
                    finalPriceOfOrder = quantity * (decimal)2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{finalPriceOfOrder:f2}");
        }
    }
}
