using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceCount = new Dictionary<string, int>();

            string firstCommand = Console.ReadLine();
            while (firstCommand != "stop")
            {
                string secondCommand = Console.ReadLine();
                if (!resourceCount.ContainsKey(firstCommand))
                {
                    resourceCount.Add(firstCommand, Convert.ToInt32(secondCommand));
                    firstCommand = Console.ReadLine();
                    continue;
                }
                foreach (var pair in resourceCount)
                {
                     if (pair.Key == firstCommand)
                    {
                        resourceCount[pair.Key] += Convert.ToInt32(secondCommand);
                        break;
                    }
                }
                firstCommand = Console.ReadLine();
            }


            foreach (var pair in resourceCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
