using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLibrary
{
    public class Distance
    {
        public int Kilometer { get; set; }
        public Distance(int km)
        {
            Kilometer = km;
        }
        public static Distance Add(Distance d1, Distance d2)
        {
            int sum = d1.Kilometer + d2.Kilometer;
            return new Distance(sum);
        }
        public void Display()
        {
            Console.WriteLine($"Total Distance: {Kilometer} km");
        }
    }
}
