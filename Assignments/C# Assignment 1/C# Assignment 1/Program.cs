using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.WriteLine($"{Num1} and {Num2} are Equal");
            }
            else
            {
                Console.WriteLine($"{Num1} and {Num2} are Not Equal");

            }


        }
    }
}
