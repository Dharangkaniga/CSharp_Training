using System;
using TicketCalculator;

namespace C__Assignment__7
{
    internal class Program4
    {
        const double TotalFare = 500;

        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            ConcessionCalculator calculator = new ConcessionCalculator();
            string result = calculator.CalculateConcession(age, TotalFare);

            Console.WriteLine("Passenger Name: " + name);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}