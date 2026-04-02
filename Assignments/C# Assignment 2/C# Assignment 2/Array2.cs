using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_2
{
    internal class Array2
    {
        public static void Main()
        {
            Console.WriteLine(" Enter Marks Size: ");
            int n=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(" Enter Marks: ");
            int[] marks = new int [n];
            for(int i = 0; i < n; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += marks[i];
            }
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {total / n}");
            Console.WriteLine($"Minimum Marks: {marks.Min()}");
            Console.WriteLine($"Maximum Marks: {marks.Max()}");
            Console.WriteLine(" ");
            Array.Sort(marks);
            Console.WriteLine(" Ascending Order");

            for(int i = 0; i < n;i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Descending Order");
            for (int i = marks.Length-1; i>=0  ; i--)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine(" ");

        }
    }
}
