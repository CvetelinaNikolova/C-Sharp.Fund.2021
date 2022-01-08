using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRows; i++)
            {
                string studentsName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentsName))
                {
                    List<decimal> gradesList = new List<decimal>()
                    { 
                        studentGrade
                    };
                    students.Add(studentsName, gradesList);
                }
                else if (students.ContainsKey(studentsName))
                {
                    students[studentsName].Add(studentGrade);
                }
            }

            Dictionary<string, decimal> selectedStudents = new Dictionary<string, decimal>();

            foreach (var student in students)
            {
                string name = student.Key;
                decimal allGrades = 0;
                foreach (var grade in student.Value)
                {
                    allGrades += grade;
                }
                decimal avarageGrade = allGrades / (decimal)student.Value.Count;
                if (avarageGrade>=(decimal)4.50)
                {
                    selectedStudents.Add(name, avarageGrade);
                }
            }

            var finalDic = selectedStudents.OrderByDescending(x => x.Value);

            foreach (var student in finalDic)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
