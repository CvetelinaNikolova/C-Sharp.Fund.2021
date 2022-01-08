using System;

namespace _3.TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prices = Console.ReadLine().Split(", ");
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            int sumOfLeft = 0;
            int sumOfRigth = 0;

            int[] intPrices = new int[prices.Length];
 
            for (int i = 0; i < prices.Length; i++)
            {
                intPrices[i] = Convert.ToInt32(prices[i]);
            }


            if (typeOfItem=="cheap")
            {
                for (int i = entryPoint-1; i >=0; i--)
                {
                    if (intPrices[i]<intPrices[entryPoint])
                    {
                        sumOfLeft += intPrices[i];
                    }
                }
                for (int i = entryPoint+1; i < intPrices.Length; i++)
                {
                    if (intPrices[i]<intPrices[entryPoint])
                    {
                        sumOfRigth += intPrices[i];
                    }
                }
            }
            if (typeOfItem=="expensive")
            {
                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (intPrices[i] >= intPrices[entryPoint])
                    {
                        sumOfLeft += intPrices[i];
                    }
                }
                for (int i = entryPoint+1; i < intPrices.Length ; i++)
                {
                    if (intPrices[i]>=intPrices[entryPoint])
                    {
                        sumOfRigth += intPrices[i];
                    }
                }
            }

            if (sumOfLeft>=sumOfRigth)
            {
                Console.WriteLine($"Left - {sumOfLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {sumOfRigth}");
            }
        }
    }
}
