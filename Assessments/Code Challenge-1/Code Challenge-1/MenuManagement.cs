using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    class EmployeeData
    {
        public int ID;
        public string Name;
        public string Department;
        public double Salary;

    }
    internal class MenuManagement
    {
        public static void Main()
        {
            List<EmployeeData> emp = new List<EmployeeData>();
            int choice;
            do
            {
                Console.WriteLine("----------Employee Management Menu--------- ");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee By ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Enter Your Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee(emp);
                        break;
                    case 2:
                        ViewEmployee(emp);
                        break;
                    case 3:
                        SearchEmployee(emp);
                        break;
                    case 4:
                        UpdateEmployee(emp);
                        break;
                    case 5:
                        DeleteEmployee(emp);
                        break;
                    case 6:
                        Console.WriteLine("Exiting The Menu");
                        break;
                    default:
                        Console.WriteLine(" Invalid Choice");
                        break;


                }

            } while (choice <= 6);

        }
        static void AddEmployee(List<EmployeeData> emp)
        {
            EmployeeData emps = new EmployeeData();
            Console.Write("Enter Employee ID: ");
            emps.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            emps.Name = Console.ReadLine();
            Console.Write("Enter Employee Department: ");
            emps.Department=Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            emps.Salary = Convert.ToDouble(Console.ReadLine());
            emp.Add(emps);
            Console.WriteLine("----------Employee Added Successfully---------");

        }
        static void ViewEmployee(List<EmployeeData> emp)
        {
            if (emp.Count <= 0)
            {
                Console.WriteLine("No Employees Found");
                return;
            }
            Console.WriteLine("Employee Details");
            foreach (var e in emp)
            {
                Console.WriteLine($"EmpId: {e.ID} \nName:{e.Name}\nDepartment: {e.Department}\nSalary: {e.Salary} ");
            }
        }
        static void SearchEmployee(List<EmployeeData> emp)
        {
            Console.WriteLine("Enter Employee ID to Search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EmployeeData emps = null;
            foreach (EmployeeData e in emp)
            {
                if (e.ID == id)
                {
                    emps = e;
                    break;
                }
            }
            if (emps != null)
            {
                Console.WriteLine("Employee Found");
                Console.WriteLine($"EmpId: {emps.ID} \nName:{emps.Name}\nDepartment: {emps.Department}\nSalary: {emps.Salary} "); 
            }


        }
        static void UpdateEmployee(List<EmployeeData> emp)
        {
            Console.WriteLine("Enter Employee ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EmployeeData emps = null;
            foreach (EmployeeData e in emp)
            {
                if (e.ID == id)
                {
                    emps = e;
                    break;
                }
            }
            if (emps != null)
            {
                Console.WriteLine("Enter New Name: ");
                emps.Name = Console.ReadLine();
                Console.Write("Enter Employee Department: ");
                emps.Department = Console.ReadLine();
                Console.Write("Enter Employee Salary: ");
                emps.Salary = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }


        }
        static void DeleteEmployee(List<EmployeeData> emp)
        {
            Console.WriteLine("Enter Employee ID To Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EmployeeData emps = null;
            foreach (EmployeeData e in emp)
            {
                if (e.ID == id)
                {
                    emps = e;
                    break;
                }
            }
            if (emps != null)
            {
                emp.Remove(emps);
                Console.WriteLine("Employee Removed Successfully");
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }

        }


                

        
        
        



    }
}
