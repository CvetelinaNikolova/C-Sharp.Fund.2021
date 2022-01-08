using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            decimal energy = decimal.Parse(Console.ReadLine());
            decimal waterPerPerson = decimal.Parse(Console.ReadLine());
            decimal foodPerPerson = decimal.Parse(Console.ReadLine());
            decimal allWater = daysOfAdventure * (numberOfPeople * waterPerPerson);
            decimal allFood = daysOfAdventure * (numberOfPeople * foodPerPerson);

            bool enoughEnergy = true;

            for (int i = 1; i <=daysOfAdventure; i++)
            {
                decimal energyForWood = decimal.Parse(Console.ReadLine());
                if (energy<=energyForWood)
                {
                    enoughEnergy = false;
                    break;
                }
                energy -= energyForWood;
                if (i%2==0)
                {
                    energy += energy *(decimal)0.05;
                    allWater -= allWater * (decimal)0.3;
                }
                if (i%3==0)
                {
                    energy += energy * (decimal)0.1;
                    allFood -= (allFood / numberOfPeople);
                }
            }
            if (enoughEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {allFood:f2} food and {allWater:f2} water.");
            }
        }
    }
}
