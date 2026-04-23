
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__4
{

    /*Now once the collection is created write down and execute the LINQ queries for collection 
as follows :
 
a.Display detail of all the employee
b.Display details of all the employee whose location is not Mumbai
c.Display details of all the employee whose title is AsstManager
d.Display details of all the employee whose Last Name start with S*/
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

        public EmployeeDetails(int id, string fname, string lname, string title, string dob, string doj, string city)
        {
            EmployeeID = id;
            FirstName = fname;
            LastName = lname;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> empList = new List<EmployeeDetails>()
            {
                new EmployeeDetails(1001,"Malcolm","Daruwalla","Manager","16/11/1984","8/6/2011","Mumbai"),
                new EmployeeDetails(1002,"Asdin","Dhalla","AsstManager","20/08/1984","7/7/2012","Mumbai"),
                new EmployeeDetails(1003,"Madhavi","Oza","Consultant","14/11/1987","12/4/2015","Pune"),
                new EmployeeDetails(1004,"Saba","Shaikh","SE","3/6/1990","2/2/2016","Pune"),
                new EmployeeDetails(1005,"Nazia","Shaikh","SE","8/3/1991","2/2/2016","Mumbai"),
                new EmployeeDetails(1006,"Amit","Pathak","Consultant","7/11/1989","8/8/2014","Chennai"),
                new EmployeeDetails(1007,"Vijay","Natrajan","Consultant","2/12/1989","1/6/2015","Mumbai"),
                new EmployeeDetails(1008,"Rahul","Dubey","Associate","11/11/1993","6/11/2014","Chennai"),
                new EmployeeDetails(1009,"Suresh","Mistry","Associate","12/8/1992","3/12/2014","Chennai"),
                new EmployeeDetails(1010,"Sumit","Shah","Manager","12/4/1991","2/1/2016","Pune")
            };

            DisplayAll(empList);
            DisplayNotMumbai(empList);
            DisplayAsstManagers(empList);
            DisplayNameStartS(empList);
        }

        static void DisplayAll(List<EmployeeDetails> emplist)
        {
            Console.WriteLine("All Employees");
            Console.WriteLine(" ");
            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID} FirstName:{emp.FirstName} LastName :{emp.LastName} Title: {emp.Title} DOB: {emp.DOB} DOJ: {emp.DOJ} City: {emp.City}");           
            }
            Console.WriteLine(" ");
        }

        static void DisplayNotMumbai(List<EmployeeDetails> emplist)
        {
         
            Console.WriteLine("Employees not from Mumbai");
            Console.WriteLine(" ");
            var result = emplist.Where(e => e.City != "Mumbai");
            foreach (EmployeeDetails emp in result)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID} FirstName:{emp.FirstName} LastName :{emp.LastName} Title: {emp.Title} DOB: {emp.DOB} DOJ: {emp.DOJ} City: {emp.City}");
            }
            Console.WriteLine(" ");
        }

        static void DisplayAsstManagers(List<EmployeeDetails> emplist)
        {
            Console.WriteLine("Employee as Assist Manager");
            Console.WriteLine(" ");
            var result = emplist.Where(e => e.Title == "AsstManager");
            foreach (EmployeeDetails emp in result)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID} FirstName:{emp.FirstName} LastName :{emp.LastName} Title: {emp.Title} DOB: {emp.DOB} DOJ: {emp.DOJ} City: {emp.City}");
            }
            Console.WriteLine(" ");
        }

        static void DisplayNameStartS(List<EmployeeDetails> emplist)
        {
            Console.WriteLine("Employee Name Starts with S");
            Console.WriteLine(" ");
            var result = emplist.Where(e => e.LastName.StartsWith("S"));
            foreach (EmployeeDetails emp in result)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID} FirstName:{emp.FirstName} LastName :{emp.LastName} Title: {emp.Title} DOB: {emp.DOB} DOJ: {emp.DOJ} City: {emp.City}");
            }
            Console.WriteLine(" ");
        }
    }
}
