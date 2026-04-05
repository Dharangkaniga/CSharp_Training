using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string msg):base(msg)
        {

        }

    }
    public class BankAccount
    {
        public double Balance;
        public void Deposit(double Amount)
        {
            if (Amount <= 0)
            {
                throw new ArgumentException(" Entered Amount must Positive ");
            }
            Balance += Amount;
            Console.WriteLine($" Amount: {Balance} Deposited Successfully");
        }
        public void Withdraw(double Amount)
        {
            if (Amount <= 0)
            {
                throw new ArgumentException(" Entered Amount must Positive ");
            }
            if (Amount > Balance)
            {
                throw new InsufficientBalanceException(" InSufficient Balance!!!");
            }
            Balance -= Amount;
            Console.WriteLine($" Amount: {Balance} Withdraw Succeddfully");
        }
        public void ShowBalance()
        {
            Console.WriteLine($" Current Account Balance: {Balance}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            try
            {
                account.Deposit(1000);
                account.Withdraw(500);
                account.Withdraw(3000);
                account.Withdraw(0);
                account.ShowBalance();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(" Transaction Completed!!!");
            }


        }
    }
}
