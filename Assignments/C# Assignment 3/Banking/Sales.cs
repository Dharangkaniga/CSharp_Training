using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class SalesDetails
    {
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public int Qty;
        public string DateofSale;

        public SalesDetails(int salesNo, int productNo, double price, int qty, string dateofSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = qty;
            this.DateofSale = dateofSale;
        }
    }
    class Details : SalesDetails
    {
        public double TotAmount;

        public Details(int salesNo, int productNo, double price, int qty, string dateofSale)
            : base(salesNo, productNo, price, qty, dateofSale)
        {

        }
        public void Sales()
        {
            TotAmount = Qty * Price;
        }
        public void ShowDetails()
        {
            Console.WriteLine("---------Sales Details----------");
            Console.WriteLine($"Sales No: {SalesNo}");
            Console.WriteLine($"Product No: {ProductNo}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Date Of Sale: {DateofSale}");
            Console.WriteLine($"Total Amount: {TotAmount}");
        }
    }
        
    internal class Sales
    {
        public static void Main()
        {
            Details s=new Details(101,123,350,100,"31-03-26");
            s.Sales();
            s.ShowDetails();
        }
    }
}
