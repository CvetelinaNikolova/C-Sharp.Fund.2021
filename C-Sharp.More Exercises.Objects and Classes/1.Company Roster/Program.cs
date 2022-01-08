using System;
using System.Collections.Generic;

namespace _1.Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> listOfEmployees = new List<Employee>();
            List<Departments> listOfDepartments = new List<Departments>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(' ');
                Employee employee = new Employee();
                employee.Name = employeeInfo[0];
                employee.Salary = Convert.ToDecimal(employeeInfo[1]);
                employee.Department = employeeInfo[2];
                listOfEmployees.Add(employee);

                bool haveDepartment = false;
                foreach (Departments department in listOfDepartments)
                {
                    if (department.Name==employee.Department)
                    {
                        haveDepartment = true;
                    }
                }
                if (haveDepartment==false)
                {
                    Departments department = new Departments();
                    department.Name = employee.Department;
                    department.Salary = 0;
                    listOfDepartments.Add(department);
                }
            }

            foreach (Employee employeee in listOfEmployees)
            {
                foreach (Departments department in listOfDepartments)
                {
                    if (employeee.Department==department.Name)
                    {
                        department.Salary += employeee.Salary;
                        department.NumberOfEmployees++;
                        department.EmployeeDepList.Add(employeee);
                    }
                }
            }


            foreach (Departments department in listOfDepartments)
            {
                department.AverageSalary = department.Salary / (decimal)department.NumberOfEmployees;
            }

            Departments DepWithHighestAverSalary = new Departments();
            DepWithHighestAverSalary.AverageSalary = 0;

            foreach (Departments department in listOfDepartments)
            {
                if (department.AverageSalary>DepWithHighestAverSalary.AverageSalary)
                {
                    DepWithHighestAverSalary = department;
                }
            }

            Employee[] DepWithHighestSalaryEmployeeArr = DepWithHighestAverSalary.EmployeeDepList.ToArray();
            Array.Sort(DepWithHighestSalaryEmployeeArr, OrderBySalary);

            Console.WriteLine($"Highest Average Salary: {DepWithHighestAverSalary.Name}");
            foreach (Employee employee in DepWithHighestSalaryEmployeeArr)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }

        static int OrderBySalary(Employee employee1, Employee employee2)
        {
            return employee2.Salary.CompareTo(employee1.Salary);
        }
    }
}
