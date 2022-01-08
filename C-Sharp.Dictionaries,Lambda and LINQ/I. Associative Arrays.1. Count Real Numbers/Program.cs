using System;
using System.Collections.Generic;
using System.Linq;

namespace I._Associative_Arrays._1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();
            SortedDictionary<decimal, int> decimalDic = new SortedDictionary<decimal, int>();

            foreach (decimal number in listOfNumbers)
            {
                if (!decimalDic.ContainsKey(number))
                {
                    decimalDic.Add(number, 0);
                }
                decimalDic[number]++;
            }

            foreach (var pair in decimalDic)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
