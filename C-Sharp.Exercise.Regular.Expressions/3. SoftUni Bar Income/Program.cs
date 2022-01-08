using System;
using System.Text.RegularExpressions;


namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal finalIncome = 0;
            string input = Console.ReadLine();
            while (input!="end of shift")
            {
                Match match = Regex.Match(input, @"%(?<name>[A-Z][a-z]+)\%([^%|$.]+)?\<(?<product>\w+)\>([^%|$.]+)?\|(?<count>[0-9]{1,})\|([^%|$.]+)?(?<price>(?<=[^0-9])[0-9]+(.[0-9]+)?)\$([^%|$.]+)?");

                if (match.Success)
                {
                    string name = match.Groups["name"].ToString();
                    string product = match.Groups["product"].ToString();
                    decimal count = Convert.ToDecimal(match.Groups["count"].ToString());
                    decimal price = Convert.ToDecimal(match.Groups["price"].ToString());
                    decimal totalPrice = count * price;

                    finalIncome += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {finalIncome:f2}");
        }
    }
}
