using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class PositiveorNegative
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int Num = int.Parse(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine($"{Num} is a Positive Number");
            }
            else if (Num < 0)
            {
                Console.WriteLine($"{Num} is a Negative Number");
            }
            else
            {
                Console.WriteLine($"Given Number is Zero");
            }

        }

    }
}
