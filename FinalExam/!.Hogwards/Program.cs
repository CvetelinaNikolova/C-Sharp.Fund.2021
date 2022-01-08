using System;
using System.Linq;
using System.Text;
using System.Text;

namespace _.Hogwards
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder spell = new StringBuilder();
            spell.Append(Console.ReadLine());
            string input = Console.ReadLine();
            while (input!="Abracadabra")
            {
                string command = input.Split(" ").ElementAt(0);
                if (command=="Abjuration")
                {
                    string result = spell.ToString().ToUpper();
                    spell.Clear();
                    spell.Append(result);
                    Console.WriteLine(spell.ToString());
                }
                else if (command=="Necromancy")
                {
                    string result = spell.ToString().ToLower();
                    spell.Clear();
                    spell.Append(result);
                    Console.WriteLine(spell.ToString());
                }
                else if (command=="Illusion")
                {
                    int index = int.Parse(input.Split(" ").ElementAt(1));
                    char letter = Convert.ToChar(input.Split(" ").ElementAt(2));

                    if (index >= 0 && index <= spell.Length - 1)
                    {
                        spell[index] = letter;
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }

                }
                else if (command=="Divination")
                {
                    string firstSubstring = input.Split(" ").ElementAt(1);
                    string secondSubstring = input.Split(" ").ElementAt(2);

                    if (spell.ToString().Contains(firstSubstring))
                    {
                        spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell.ToString());
                    }
                }
                else if (command=="Alteration")
                {
                    string substring = input.Split(" ").ElementAt(1);
                    if (spell.ToString().Contains(substring))
                    {
                        if (spell.ToString().Contains(substring))
                        {
                            spell.Replace(substring, "");
                            Console.WriteLine(spell.ToString());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
