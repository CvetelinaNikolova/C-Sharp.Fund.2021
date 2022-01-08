using System;
using System.Text;

namespace _1___World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            string input = Console.ReadLine();
            while (input!="Travel")
            {
                string[] command = input.Split(":");
                string action = command[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string stop = command[2];
                    if (index >= 0 && index <= text.Length - 1)
                    {
                        text.Insert(index, stop);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if ((startIndex<=text.Length-1&&startIndex>=0)&&(endIndex>=0&&endIndex<=text.Length-1))
                    {
                        int lenght = endIndex - startIndex + 1;
                        text.Remove(startIndex, lenght);
                    }
                }
                else if (action=="Switch")
                {
                    string prevWord = command[1];
                    string newWord = command[2];
                    text.Replace(prevWord, newWord);
                }
                Console.WriteLine(text.ToString());
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text.ToString()}");
        }
    }
}
