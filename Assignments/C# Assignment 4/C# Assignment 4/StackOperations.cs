using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_4
{
    internal class StackOperations
    {
        public static void Main()
        {
            Console.Write("Enter number of Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Stack<int>stack=new Stack<int>();
            int[]arr=new int[n];
            Console.WriteLine("Enter Elements: ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for(int i=0; i <n; i++)
            {
                stack.Push(arr[i]);
            }

            Console.WriteLine("Stack Elements in Descending Order: ");
            foreach(var v in stack)
            {
                Console.Write(v + " ");
            }
        }
    }
}
