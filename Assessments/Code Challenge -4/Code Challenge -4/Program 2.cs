using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistanceLibrary;

namespace Code_Challenge__4
{
    /*Write a class Distance that has int Kilometer as its member. 
     * Write a function that adds 2 Distance objects and sums up in the 3rd. 
     * Display the 3rd object details. Create a Test class to execute the above*/
    
    internal class Program_2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Distance 1 : ");
            int km1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Distance 2 : ");
            int km2 = Convert.ToInt32(Console.ReadLine());

            Distance d1 = new Distance(km1);
            Distance d2 = new Distance(km2);

            Distance d3 = Distance.Add(d1, d2);
            Console.WriteLine(" ");
            Console.WriteLine($"--- Sum Of Two Distance ---");
            d3.Display();

            
        }
    }

}

