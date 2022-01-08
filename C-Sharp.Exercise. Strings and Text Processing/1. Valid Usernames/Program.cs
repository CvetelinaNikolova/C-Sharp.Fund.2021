using System;
using System.Collections.Generic;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");
            List<string> validUsers = new List<string>();

            for (int i = 0; i < users.Length; i++)
            {
                bool validUser = true;
                if (users[i].Length<3||users[i].Length>16)
                {
                    validUser = false;
                }
                char[] charUser = users[i].ToCharArray();
                for (int j = 0; j < charUser.Length; j++)
                {
                    if (!char.IsLetterOrDigit(users[i], j))
                    {
                        if (charUser[j]!='-'&&charUser[j]!='_')
                        {
                        validUser = false;
                        }
                    }
                }
                if (validUser)
                {
                    validUsers.Add(users[i]);
                }
            }

            foreach (string user in validUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
