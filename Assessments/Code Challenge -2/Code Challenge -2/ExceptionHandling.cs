using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__2
{
    class NumbersCheckingException : Exception
    {
        public NumbersCheckingException(string msg): base(msg) 
        {

        }
    }
    public class ExceptionHandling
    {
       public static void CheckNumber(int num)
        {
            if(num<0)
            {
                throw new NumbersCheckingException(" Number Cannot be Negative!!!");
            }
            else
            {
                Console.WriteLine($" Number is Valid: {num}");
            }
        }
    }
    class Number
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                ExceptionHandling.CheckNumber(num);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!! {e.Message}");
            }
            finally
            {
                Console.WriteLine("..........Number Checked Successfully........");
            }

        }
    }
}
        
        

