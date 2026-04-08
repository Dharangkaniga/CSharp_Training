using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__2
{
    class Product
    {
        public int ProductID;
        public string ProductName;
        public int ProductPrice;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] P = new Product[10];
            for (int i = 0; i <10; i++)
            {
                P[i] = new Product();

                Console.Write($"Enter Product {i+1} ID: ");
                P[i].ProductID = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Product {i+1} Name: ");
                P[i].ProductName = Console.ReadLine();

                Console.Write($"Enter Product {i+1} Price: ");
                P[i].ProductPrice = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i<P.Length-1; i++)
            {
                for (int j = i + 1; j < P.Length; j++)
                {
                    if (P[i].ProductPrice > P[j].ProductPrice)
                    {
                        Product temp = P[i];
                        P[i] = P[j];
                        P[j] = temp;
                    }
                }
            }

            Console.WriteLine("Products Sorted by Price");
            for (int i = 0; i <P.Length; i++)
            {
                Console.WriteLine($"Product ID: {P[i].ProductID}\nProduct Name: {P[i].ProductName}\nProduct Price: {P[i].ProductPrice}");
            }
            Console.ReadLine();
        }
    }
}