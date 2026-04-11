using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Assignment__7
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public string EmpCity;
        public double EmpSalary;

        public static void DisplayEmployee(List<Employee> employees)
        {
            Console.WriteLine("All Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmpId} {emp.EmpName} {emp.EmpCity} {emp.EmpSalary}");
            }
        }

        public static void DisplayHighSalary(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees with Salary > 45000:");
            foreach (var emp in employees)
            {
                if (emp.EmpSalary > 45000)
                {
                    Console.WriteLine($"{emp.EmpId} {emp.EmpName} {emp.EmpCity} {emp.EmpSalary}");
                }
            }
        }

        public static void DisplayBangaloreEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees from Bangalore:");
            foreach (var emp in employees)
            {
                if (emp.EmpCity == "Bangalore")
                {
                    Console.WriteLine($"{emp.EmpId} {emp.EmpName} {emp.EmpCity} {emp.EmpSalary}");
                }
            }
        }

        public static void DisplaySortedByName(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees sorted by Name:");
            var result = employees.OrderBy(e => e.EmpName);
            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmpId} {emp.EmpName} {emp.EmpCity} {emp.EmpSalary}");
            }
        }
    }

    internal class Program3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmpId = 1, EmpName = "Ravi", EmpCity = "Bangalore", EmpSalary = 50000 },
                new Employee { EmpId = 2, EmpName = "Sita", EmpCity = "Hyderabad", EmpSalary = 40000 },
                new Employee { EmpId = 3, EmpName = "John", EmpCity = "Bangalore", EmpSalary = 60000 },
                new Employee { EmpId = 4, EmpName = "Anu", EmpCity = "Chennai", EmpSalary = 30000 }
            };

            Employee.DisplayEmployee(employees);
            Employee.DisplayHighSalary(employees);
            Employee.DisplayBangaloreEmployees(employees);
            Employee.DisplaySortedByName(employees);

            Console.ReadLine();
        }
    }
}