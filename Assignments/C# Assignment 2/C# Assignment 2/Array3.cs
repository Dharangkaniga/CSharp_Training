using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_2
{
    internal class Array3
    {
        public static void Main()
        {
            Console.WriteLine("Enter Size Of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] original = new int[n];
            Console.WriteLine("Enter Array Elements: ");
            for (int i = 0; i < n; i++)
            {
                original[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] copy = new int[n];
            for (int i = 0; i < n; i++)
            {
                copy[i] = original[i];
            }
            Console.WriteLine("----Original Array Elements----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(original[i]);
            }
            Console.WriteLine("----Copied Array Elements----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(copy[i]);
            }
        }
    }
}
