using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_2
{
    internal class Array1
    {
        static void Main()
        {
            Console.Write("Enter Size Of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Array Elements: ");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($" Average Of Array Elements: {sum / n}");
            Console.WriteLine($" Minimum Element: {arr.Min()}");
            Console.WriteLine($" Maximum Element: {arr.Max()}");

        }
    }
}
