using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_4
{
    internal class PositionExchange
    {
        public static void Main()
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine();
            Console.WriteLine("Before Position Exchange");
            Console.WriteLine(str);
            if (str.Length<=1)
            {
                Console.WriteLine("After Position Exchange");
                Console.WriteLine($" Result: {str}");
            }
            else
            {
                char[] arr = str.ToCharArray();
                char temp = arr[0];
                arr[0] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
                string array=new string(arr);
                Console.WriteLine("After Position Exchange");
                Console.WriteLine($"Result: {array}");
            }




        }
    }
}
