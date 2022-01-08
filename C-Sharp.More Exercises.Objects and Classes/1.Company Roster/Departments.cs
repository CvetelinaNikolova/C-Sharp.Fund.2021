using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Company_Roster
{
    class Departments
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal AverageSalary { get; set; }

        public List<Employee> EmployeeDepList = new List<Employee>();
    }
}
