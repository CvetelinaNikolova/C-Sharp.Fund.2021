using System;
namespace _11._Snowballs
    {
        class Program
        {
            static void Main(string[] args)
            {
                int numberOfSnowballs = int.Parse(Console.ReadLine());
                double finalSnowballValue = 0;
                int finalSnowBallSnow = 0;
                int finalSnowBallTime = 0;
                int finalSnowBallQuality = 0;

                for (int i = 0; i < numberOfSnowballs; i++)
                {
                    int snowBallSnow = int.Parse(Console.ReadLine());
                    int snowBallTime = int.Parse(Console.ReadLine());
                    int snowBallQuality = int.Parse(Console.ReadLine());
                    double currentSnowballValue = (double)Math.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                    if (finalSnowballValue < currentSnowballValue&&snowBallTime>0)
                    {
                        finalSnowballValue = currentSnowballValue;
                        finalSnowBallSnow = snowBallSnow;
                        finalSnowBallTime = snowBallTime;
                        finalSnowBallQuality = snowBallQuality;
                    }
                }
                Console.WriteLine($"{finalSnowBallSnow} : {finalSnowBallTime} = {finalSnowballValue} ({finalSnowBallQuality})");
            }
        }
    }
