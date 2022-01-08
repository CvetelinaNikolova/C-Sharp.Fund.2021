using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysInTheMine = 0;
            int totalSpicesExtracted = 0;
            int spicesForTheCrew = 26;
            while (startingYield>=100)
            {
                totalSpicesExtracted += startingYield;
                daysInTheMine++;
                totalSpicesExtracted -= spicesForTheCrew;
                startingYield -= 10;
            }
            if (spicesForTheCrew<=totalSpicesExtracted)
            {
            totalSpicesExtracted -= spicesForTheCrew;
            }

            Console.WriteLine($"{daysInTheMine}");
            Console.WriteLine($"{totalSpicesExtracted}");
        }
    }
}
