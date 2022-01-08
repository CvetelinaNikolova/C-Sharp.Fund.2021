using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double moneySpend = 0;
            while (input != "Game Time")
            {
                double priceOfGame = 0;
                bool isFound = true;
                switch (input)
                {
                    case "OutFall 4":
                        priceOfGame = 39.99;
                        break;
                    case "CS: OG":
                        priceOfGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceOfGame = 19.99;
                        break;
                    case "Honored 2":
                        priceOfGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceOfGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceOfGame = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        isFound = false;
                        break;
                }
                if (priceOfGame > balance)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                if (isFound == true)
                {
                    Console.WriteLine($"Bought {input}");
                }
                moneySpend += priceOfGame;
                balance -= priceOfGame;
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                input = Console.ReadLine();

            }
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
