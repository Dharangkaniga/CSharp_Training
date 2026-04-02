using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    struct DetailsOfBirth
    {
        public int Date;
        public int Month;
        public int Year;
    }
    struct Employee
    {
        public string Name;
        public DetailsOfBirth DOB;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Employees: ");
            int n=Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Employee Name: ");
                emp[i].Name = Console.ReadLine();
                Console.Write("Date Of Birth:");
                emp[i].DOB.Date = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month Of Birth: ");
                emp[i].DOB.Month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Year Of Birth: ");
                emp[i].DOB.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
            }

            Console.WriteLine("--------Employee Details-------");
            Console.WriteLine(" ");

            for(int i = 0; i < n;i++) 
            {
                Console.WriteLine($"Employee Name : {emp[i].Name}");
                Console.WriteLine($"Date Of Birth : {emp[i].DOB.Date}");
                Console.WriteLine($"Month Of Birth: {emp[i].DOB.Month}");
                Console.WriteLine($"Year Of Birth : {emp[i].DOB.Year}");
                Console.WriteLine(" ");
            }

        }
    }
}
