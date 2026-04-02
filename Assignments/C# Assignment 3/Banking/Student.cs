using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class StudentDetails
    {
        public int RollNo;
        public string StdName;
        public string ClassName;
        public int Semester;
        public string Branch;

        public StudentDetails(int RollNo, string StdName, string ClassName, int Semester, string Branch)
        {
            this.RollNo = RollNo;
            this.StdName = StdName;
            this.ClassName = ClassName;
            this.Semester = Semester;
            this.Branch = Branch;
        }
    }
    class ResultDetails : StudentDetails
    {
        int[] Marks=new int[5];
        public ResultDetails(int RollNo, string StdName, string ClassName, int Semester, string Branch)
            :base(RollNo,StdName,ClassName,Semester,Branch)
        {

        }
        public void GetMarks()
        {
            Console.WriteLine("Enter The Subjects Marks: ");
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void DisplayResult()
        {
            int Total = 0;
            int avg = 0;
            bool Fail = false;
            for (int i = 0; i < 5; i++)
            {
                Total += Marks[i];
                if (Marks[i] < 35)
                {
                    Fail = true;
                }
            }
            avg = Total / 5;
            if (Fail == true || avg < 50)
            {
                Console.WriteLine("Result : Failed ");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Passed in All Subjects");
                Console.WriteLine($"Average of Total Marks : {avg}");
                Console.WriteLine(" ");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("------------Student Details------------");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Student Name: {StdName}");
            Console.WriteLine($"Student Class: {ClassName}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch : {Branch}");
            Console.WriteLine(" ");
        }
    }
    internal class Student
    {
        public static void Main()
        {
            ResultDetails student1 = new ResultDetails(1,"Charan","B.Tech",5,"IT");
            student1.GetMarks();
            student1.DisplayResult();
            student1.DisplayDetails();
        }
    }
}
