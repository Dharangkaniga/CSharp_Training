using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Enter position: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            string result = str.Remove(pos, 1);

            Console.WriteLine($"Result: {result}");

        }
    }
}
