using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
