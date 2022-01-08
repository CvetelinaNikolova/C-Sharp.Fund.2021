using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int mens = 15;
            int ladies = 20;
            int kids = 10;
            int touchUp = 20;
            int fullColor = 30;
            int profit = 0;
            while ((profit < goal) && (service != "closed"))
            {
                string service2 = Console.ReadLine();
                while (service2 != "closed")
                    {
                        service = Console.ReadLine();
                    service2 = Console.ReadLine();
                        if (service == "haircut")
                        {
                            if (service2 == "men")
                            {
                                profit += mens;
                            }
                            if (service2 == "ladies")
                            {
                                profit += ladies;
                            }
                            if (service2 == "kids")
                            {
                                profit += kids;
                            }
                        }
                        if (service == "color")
                        {
                            if (service2 == "touch up")
                            {
                                profit += touchUp;
                            }
                            if (service2 == "full color")
                            {
                                profit += fullColor;
                            }
                        }
                    }
                break;
            }
            if (goal <= profit)
            {
                Console.WriteLine($"You have reached your target for the day!");
            }
            if (goal > profit)
            {
                int moneyToGo = goal - profit;
                Console.WriteLine($"Target not reached! You need {moneyToGo}lv. more.");
            }
            Console.WriteLine($"Earned money: {profit}lv.");
        }
    }
}
