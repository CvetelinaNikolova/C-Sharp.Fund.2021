﻿using System;

namespace _1.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { 
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int num = int.Parse(Console.ReadLine());
            if (num<=7&&num>0)
            {
                Console.WriteLine(days[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
