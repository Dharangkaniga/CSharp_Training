using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using NorthwindMVC.Models;

namespace NorthwindMVC.Controllers
{
    public class OrdersMVCController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string baseUrl = "https://localhost:44320/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri(baseUrl);

            var response = await client.GetAsync("api/orders/buchanan");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<OrderMVC>>(json);

                return View(data);
            }

            return View(new List<OrderMVC>());
        }
    }
}