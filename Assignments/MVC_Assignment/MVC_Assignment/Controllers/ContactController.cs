using MVC_Assignment.Models;
using MVC_Assignment.Repositories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC_Assignment.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _repo;

        public ContactController()
        {
            _repo = new ContactRepository();
        }

        // GET: Contact
        public async Task<ActionResult> Index()
        {
            var data = await _repo.GetAllAsync();
            return View(data);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _repo.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Delete
        public async Task<ActionResult> Delete(long id)
        {
            await _repo.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}