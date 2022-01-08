using System;
using System.Collections.Generic;
using System.Linq;

namespace II._LINQ._4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] listOfNumbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .OrderByDescending(n => n)
                .ToArray();
            Console.WriteLine(string.Join(" ",listOfNumbers.Take(3)));
        }
    }
}
