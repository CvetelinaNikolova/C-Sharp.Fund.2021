using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(",");
            for (int i = 0; i < demons.Length; i++)
            {
                demons[i] = demons[i].Trim();
            }
            Array.Sort(demons);

            for (int i = 0; i < demons.Length; i++)
            {
                string name = demons[i];
                Match nameMatch = Regex.Match(name, @"^[^, ]+$");

                if (nameMatch.Success)
                {
                    MatchCollection matches = Regex.Matches(name, @"[^0-9+\-*\/.]");
                    decimal health = 0;
                    foreach (Match match in matches)
                    {
                        health += (decimal)Convert.ToChar(match.Value);
                    }

                    MatchCollection numbers = Regex.Matches(name, @"[\-|+]*([0-9]+[.])*[0-9]+");
                    decimal damage = 0;
                    foreach (Match match in numbers)
                    {
                        if (match.Value[0] == '-')
                        {
                            string number = "";
                            for (int j = 1; j < match.Value.Length; j++)
                            {
                                number += match.Value[j];
                            }

                            decimal num = Convert.ToDecimal(number);
                            damage -= num;
                        }
                        else if (match.Value[0] == '+')
                        {
                            string number = "";
                            for (int j = 1; j < match.Value.Length; j++)
                            {
                                number += match.Value[j];
                            }
                            decimal num = Convert.ToDecimal(number);
                            damage += num;
                        }
                        else
                        {
                            decimal num = Convert.ToDecimal(match.Value);
                            damage += num;
                        }
                    }

                    MatchCollection symbols = Regex.Matches(name, @"[*|\/]");

                    foreach (Match symbol in symbols)
                    {
                        if (symbol.Value == "*")
                        {
                            damage *= 2;
                        }
                        else if (symbol.Value == "/")
                        {
                            damage /= 2;
                        }
                    }

                    Console.WriteLine($"{name} - {health:f0} health, {damage:f2} damage");
                }
            }
         }
    }
}
