using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userList = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0]=="register")
                {
                    if (userList.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                    else
                    {
                        string username = command[1];
                        string plate = command[2];
                        userList.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                }

                if (command[0]=="unregister")
                {
                    if (userList.ContainsKey(command[1]))
                    {
                        userList.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach (var pair in userList)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
