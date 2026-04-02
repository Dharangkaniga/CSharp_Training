using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Operations
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation:");
            char Operation = Console.ReadLine()[0];
            Console.WriteLine("Enter Second Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            switch (Operation)
            {
                case '+':
                    Console.WriteLine("Result:");
                    Console.WriteLine($"{Num1} {Operation} {Num2}={Num1 + Num2}");
                    break;

                case '-':
                    Console.WriteLine("Result:");
                    Console.WriteLine($"{Num1} {Operation} {Num2}={Num1 - Num2}");
                    break;

                case '*':
                    Console.WriteLine("Result:");
                    Console.WriteLine($"{Num1} {Operation} {Num2}={Num1 * Num2}");
                    break;

                case '/':
                    if (Num2 != 0)
                    {
                        Console.WriteLine("Result:");
                        Console.WriteLine($"{Num1}{Operation}{Num2}=  {Num1 / Num2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Result:");
                        Console.WriteLine("Cannot be divisible by Zero");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }


        }

    }
}
