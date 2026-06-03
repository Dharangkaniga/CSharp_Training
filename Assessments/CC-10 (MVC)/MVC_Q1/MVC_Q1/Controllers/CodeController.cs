using System.Linq;
using System.Web.Mvc;
using MVC_Q1.Models;
using System.Data.Entity;

namespace MVC_Q1.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        // Action Method 1 for customers from germany
        public ActionResult GermanyCustomers()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }

        // Action Method 2 for order
        public ActionResult OrderCustomer()
        {
            var customer = (from o in db.Orders
                            join c in db.Customers
                            on o.CustomerID equals c.CustomerID
                            where o.OrderID == 10248
                            select c)
                            .FirstOrDefault();

            return View(customer);
        }
    }
}