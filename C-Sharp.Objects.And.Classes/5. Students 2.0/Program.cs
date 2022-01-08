using System;
using System.Collections.Generic;

namespace _5._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<SecondStudentTask> students = new List<SecondStudentTask>();
            while (input[0] != "end")
            {
                SecondStudentTask student = new SecondStudentTask();
                student.FisrtName = input[0];
                student.LastName = input[1];
                student.Age = input[2];
                student.HomeTown = input[3];
                bool haveStudent = false;
                if (students.Count > 0)
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (students[i].FisrtName == student.FisrtName && students[i].LastName == student.LastName)
                        {
                            students[i].Age = student.Age;
                            haveStudent = true;
                        }
                    }
                }
                else
                {
                    students.Add(student);
                    haveStudent = true;
                }
                if (haveStudent == false)
                {
                    students.Add(student);
                }
                input = Console.ReadLine().Split(' ');
            }
            string city = Console.ReadLine();
            foreach (SecondStudentTask student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FisrtName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
