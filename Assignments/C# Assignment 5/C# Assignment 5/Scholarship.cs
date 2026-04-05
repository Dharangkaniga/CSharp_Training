using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string msg):base(msg)
        {

        }
    }
    public class ScholarshipCalculation
    {
        public double Merit(int Marks, double fees)
        {
            if (Marks >= 70 && Marks <= 80)
            {
                return fees * 0.20;
            }
            else if (Marks >= 80 && Marks <= 90)
            {
                return fees * 0.30;
            }
            else if (Marks >= 90)
            {
                return fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException(" Marks Not Eligible For Scholarship");
            }

        }
    }
    internal class Scholarship
    {
        public static void Main()
        {
            ScholarshipCalculation sc = new ScholarshipCalculation();
            double amount;
            try
            {
                amount= sc.Merit(85,10000);
                Console.WriteLine($" Scholarship Amount: {amount}");
                amount = sc.Merit(65,10000);
                Console.WriteLine($" Scholarship Amount: {amount}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($" Scholarship Calculated!!!");
            }
        }
    }
}
