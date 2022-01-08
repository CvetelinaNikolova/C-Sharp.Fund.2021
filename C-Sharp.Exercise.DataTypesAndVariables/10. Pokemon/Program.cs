using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            double pokePower = double.Parse(Console.ReadLine());
            double distanceBetweenTargets = double.Parse(Console.ReadLine());
            double exhaustionFactor = double.Parse(Console.ReadLine());
            int countOfPokes = 0;
            double halfOfPokePower = pokePower * 0.5;

            while (pokePower >= distanceBetweenTargets)
            {
                countOfPokes++;
                pokePower -= distanceBetweenTargets;
                if (pokePower == halfOfPokePower && pokePower >= exhaustionFactor && exhaustionFactor != 0)
                {
                    pokePower = (int)(pokePower / exhaustionFactor);
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countOfPokes);
        }
    }
}
