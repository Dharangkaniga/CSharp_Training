using Q2__API_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;

namespace Q2__API_.Controllers
{
    public class OrdersController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        [HttpGet]
        [Route("api/orders/buchanan")]
        public IHttpActionResult GetOrdersBySteven()
        {
            var orders = db.Orders
                           .Where(o => o.EmployeeID == 5)
                           .Select(o => new
                           {
                               o.OrderID,
                               o.CustomerID,
                               o.OrderDate,
                               o.ShipName
                           })
                           .ToList();

            return Ok(orders);
        }
    }
}