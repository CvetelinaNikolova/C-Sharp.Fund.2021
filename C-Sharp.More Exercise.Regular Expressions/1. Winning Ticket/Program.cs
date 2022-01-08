using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(",");

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i].Trim();
                if (ticket.Length == 20)
                {
                    string leftSide = ticket.Substring(0, 9);
                    string rightSide = ticket.Substring(10, 19);

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }
    }
}
