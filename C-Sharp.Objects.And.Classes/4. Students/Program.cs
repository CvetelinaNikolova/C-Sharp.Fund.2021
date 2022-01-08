using System;
using System.Collections.Generic;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<Student> students = new List<Student>();
            while (input[0]!="end")
            {
                Student student = new Student();
                student.FisrtName = input[0];
                student.LastName = input[1];
                student.Age = input[2];
                student.HomeTown = input[3];
                students.Add(student);
                input = Console.ReadLine().Split(' ');
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown==city)
                {
                    Console.WriteLine($"{student.FisrtName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
