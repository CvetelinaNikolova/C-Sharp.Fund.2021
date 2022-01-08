using System;

namespace FirstLecture
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool ifFruit = default;
            bool noErrorDay = default;
            bool workDay = default;
            switch (fruit)
            {
                case "banana":
                case "apple":
                case "orange":
                case "grapefruit":
                case "kiwi":
                case "pineapple":
                case "grapes":
                    ifFruit = true;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    workDay = true;
                    noErrorDay = true;
                    break;
                case "Saturday":
                case "Sunday":
                    workDay = false;
                    noErrorDay = true;
                    break;
                default:
                    if (ifFruit == true)
                    {
                        Console.WriteLine("error");
                    }
                    break;
            }

            if ((ifFruit == true) && (noErrorDay == true))
            {
                if (workDay == true)
                {
                    switch (fruit)
                    {
                        case "banana":
                            double priceForBanana = quantity * 2.50;
                            Console.WriteLine($"{priceForBanana:f2}");
                            break;
                        case "apple":
                            double priceForApple = quantity * 1.20;
                            Console.WriteLine($"{priceForApple:f2}");
                            break;
                        case "orange":
                            double priceForOrange = quantity * 0.85;
                            Console.WriteLine($"{priceForOrange:f2}");
                            break;
                        case "grapefruit":
                            double priceForGrapefruit = quantity * 1.45;
                            Console.WriteLine($"{priceForGrapefruit:f2}");
                            break;
                        case "kiwi":
                            double priceForKiwi = quantity * 2.70;
                            Console.WriteLine($"{priceForKiwi:f2}");
                            break;
                        case "pineapple":
                            double priceForPineapple = quantity * 5.50;
                            Console.WriteLine($"{priceForPineapple:f2}");
                            break;
                        case "grapes":
                            double priceForGrapes = quantity * 3.85;
                            Console.WriteLine($"{priceForGrapes:f2}");
                            break;
                    }
                }
                if (workDay == false)
                {
                    switch (fruit)
                    {
                        case "banana":
                            double priceForBanana1 = quantity * 2.70;
                            Console.WriteLine($"{priceForBanana1:f2}");
                            break;
                        case "apple":
                            double priceForApple = quantity * 1.25;
                            Console.WriteLine($"{priceForApple:f2}");
                            break;
                        case "orange":
                            double priceForOrange1 = quantity * 0.90;
                            Console.WriteLine($"{priceForOrange1:f2}");
                            break;
                        case "grapefruit":
                            double priceForGrapefruit = quantity * 1.60;
                            Console.WriteLine($"{priceForGrapefruit:f2}");
                            break;
                        case "kiwi":
                            double priceForKiwi = quantity * 3.00;
                            Console.WriteLine($"{priceForKiwi:f2}");
                            break;
                        case "pineapple":
                            double priceForPineapple = quantity * 5.60;
                            Console.WriteLine($"{priceForPineapple:f2}");
                            break;
                        case "grapes":
                            double priceForGrapes = quantity * 4.20;
                            Console.WriteLine($"{priceForGrapes:f2}");
                            break;
                    }
                }
            }
            
        }
    }
}
