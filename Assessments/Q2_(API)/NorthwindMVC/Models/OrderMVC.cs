using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMVC.Models
{
    public class OrderMVC
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}