using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class AccountDetails
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public double Balance;

        public AccountDetails(int AccountNo,string CustomerName,string AccountType,double Balance)
        {
            this.AccountNo = AccountNo;
            this.CustomerName = CustomerName;
            this.AccountType = AccountType;
            this.Balance = Balance;
        }
        
    }
    class Transaction : AccountDetails
    {
        char TransType;
        double Amount;

        public Transaction(int AccountNo, string CustomerName, string AccountType, double Balance) 
            : base(AccountNo, CustomerName, AccountType, Balance)
        {


        }
        public void Credit(double Amount)
        {
            Balance += Amount;
            Console.WriteLine($"Amount Credited Successfully : {Amount}");
            Console.WriteLine($"Account Balance: {Balance}");
            Console.WriteLine(" ");
        }
        public void Debit(double Amount)
        {
            if(Amount<=Balance)
            {
                Balance -= Amount;
                Console.WriteLine($"Amount Debited Successfully: {Amount}");
                Console.WriteLine($"Account Balance: {Balance}");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("In-Sufficient Balance ");
            }
        }
        public void DoTransaction(char TransType,double Amount)
        {
            if(TransType=='D')
            {
                Credit(Amount);
            }
            else if(TransType=='W')
            {
                Debit(Amount);
            }
            else
            {
                Console.WriteLine(" In-Valid Transaction Type");
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine("----------Customer Details---------");
            Console.WriteLine($"Account No: {AccountNo}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Balance:{Balance}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction ts1 = new Transaction(238, "Arun", "Savings", 10000);
            ts1.DoTransaction('D', 5000);
            ts1.DoTransaction('W', 10000);
            ts1.ShowDetails();
            Transaction ts2 = new Transaction(298, "Charan", "Current", 3000);
            ts2.DoTransaction('D', 2000);
            ts2.DoTransaction('W', 9000);
            ts2.ShowDetails();
        }
    }
}
