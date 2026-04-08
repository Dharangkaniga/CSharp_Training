using Code_Challenge__2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__2
{
    abstract class Students
    {
        public string Name;
        public int StudentID;
        public double Grade;

        public abstract bool IsPassed();
    }
    class Undergraduate : Students
    {
        public override bool IsPassed()
        {
            return Grade > 70.0;
        }
    }
    class Graduate : Students
    {
        public override bool IsPassed()
        {
            return Grade > 80.0;
        }
    }

    class Student
    {
        static void Main(string[] args)
        {
            Undergraduate ugStudent = new Undergraduate()
            {
                Name = "Alice",
                StudentID = 101,
                Grade = 75.0
            };
            Graduate gradStudent = new Graduate()
            {
                Name = "Bob",
                StudentID = 201,
                Grade = 78.0
            };

            Console.WriteLine($"Undergraduate {ugStudent.Name} Passed: {ugStudent.IsPassed()}");
            Console.WriteLine($"Graduate {gradStudent.Name} Passed: {gradStudent.IsPassed()}");

            Console.ReadLine();
        }
    }
}