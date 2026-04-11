using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {9,4,5,1,8 };

            var result = numbers
                .Select(n => new { Number = n, Square = n * n })
                .Where(x => x.Square > 20);

            foreach (var item in result)
            {
                Console.WriteLine($"Number is:{item.Number} Square is:{item.Square}");
            }

        }
    }
}
