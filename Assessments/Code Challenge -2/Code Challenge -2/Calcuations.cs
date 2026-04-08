using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__2
{
    internal class Calcuations
    {
        public delegate void Calculator(int a, int b);
        static void Add(int a,int b)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Addition: {a + b}");
            
        }
        static void Sub(int a,int b)
        {
            Console.WriteLine($"Subraction: {a - b}");
        }
        static void Mul(int a,int b)
        {
            Console.WriteLine($"Multiplication: {a * b}");
        }






        public static void Main()
        {
            Console.Write("Enter Num1: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            int b=Convert.ToInt32(Console.ReadLine());

            Calculator add = Add;
            Calculator sub = Sub;
            Calculator mul = Mul;

            add(a, b);
            sub(a, b);
            mul(a, b);
        }
    }
}
