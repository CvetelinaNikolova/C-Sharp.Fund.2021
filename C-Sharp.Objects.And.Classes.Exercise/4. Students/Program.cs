using System;
using System.Collections.Generic;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation students = new StudentInformation();
            students.Students = new List<Student>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                string[] studentInfo = Console.ReadLine().Split(' ');

                student.FirstName = studentInfo[0];
                student.LastName = studentInfo[1];
                student.Grade = Convert.ToDecimal(studentInfo[2]);

                students.Students.Add(student);
            }

            Student[] studentArr = students.Students.ToArray();

            Array.Sort(studentArr, OrderByGrade);

            foreach (Student student in studentArr)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }

        static int OrderByGrade(Student student1, Student student2)
        {
          return  student2.Grade.CompareTo(student1.Grade);
        }
    }
}
