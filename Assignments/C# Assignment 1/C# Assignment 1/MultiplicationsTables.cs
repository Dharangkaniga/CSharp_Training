using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class MultiplicationsTables
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Tables Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{Number}* {i}= {Number * i}");
            }

        }

    }
}
