using System;
namespace Task
{
        class Program
        {
            static void Main(string[] args)
            {
                int days = int.Parse(Console.ReadLine());
                double food = double.Parse(Console.ReadLine());
                double foodForDeer1ADay = double.Parse(Console.ReadLine());
                double foodForDeer2ADay = double.Parse(Console.ReadLine());
                double foodForDeer3ADay = double.Parse(Console.ReadLine());
                double foodForDeer1 = foodForDeer1ADay * days;
                double foodForDeer2 = foodForDeer2ADay * days;
                double foodForDeer3 = foodForDeer3ADay * days;
                double foodForAllDeers = foodForDeer1 + foodForDeer2 + foodForDeer3;
                if (food >= foodForAllDeers)
                {
                    double foodLeft = food - foodForAllDeers;
                    Console.WriteLine($"{Math.Ceiling(foodLeft)} kilos of food left.");
                }
                else if (foodForAllDeers > food)
                {
                    double foodNeeded = foodForAllDeers - food;
                    Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
                }

            }
        }
    }

