using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> users = new Dictionary<string, Dictionary<string, decimal>>();

            Dictionary<string, int> languages = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input!="exam finished")
            {
                string[] info = input.Split("-");
                string username = info[0];

                if (info[1]=="banned")
                {
                    foreach (var lang in users)
                    {
                        if (users.Values.Any(x=>x.ContainsKey(username)))
                        {
                            users[lang.Key].Remove(username);
                        }
                    }
                    input = Console.ReadLine();
                    continue;
                }

                string language = info[1];
                decimal points = Convert.ToDecimal(info[2]);

                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 0);
                }
                if (!users.ContainsKey(language))
                {
                    users.Add(language, new Dictionary<string, decimal>());
                    users[language].Add(username, points);
                    languages[language]++;
                }
                else if (users.ContainsKey(language))
                {
                    if (!users[language].ContainsKey(username))
                    {
                        users[language].Add(username, points);
                        languages[language]++;
                    }
                    else if (users[language].ContainsKey(username))
                    {
                        if (users[language][username]<points)
                        {
                        users[language][username] = points;
                        }
                        languages[language]++;
                    }
                }

                input = Console.ReadLine();
            }

            var usersScore = new Dictionary<string, decimal>();

            foreach (var language in users)
            {
                foreach (var USERS in language.Value)
                {
                    usersScore.Add(USERS.Key, USERS.Value);
                }
            }

            var orderedUsersScore = usersScore.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);

            var orderedSubmissions = languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine("Results:");
            foreach (var user in orderedUsersScore)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in orderedSubmissions)
            {
                if (language.Value>0)
                {
                Console.WriteLine($"{language.Key} - {language.Value}");
                }
            }
        }
    }
}
