using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] info = command.Split(" : ");
                if (!courses.ContainsKey(info[0]))
                {
                    List<string> studentsList = new List<string>()
                    {
                        info[1]
                    };
                    courses.Add(info[0], studentsList);
                }
                else if (courses.ContainsKey(info[0]))
                {
                    courses[info[0]].Add(info[1]);
                }

                command = Console.ReadLine();
            }

            var orderedDic = courses.OrderByDescending(x => x.Value.Count);
            courses.OrderBy(x => x.Value.Count).ToDictionary(x=>x.Key);
            foreach (var course in orderedDic)
            {
                courses[course.Key].Sort();
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student.ToString()}");
                }
            }
        }
    }
}
