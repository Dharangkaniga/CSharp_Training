using MVC_Q2.Models;
using MVC_Q2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Q2.Controllers
{
    public class MovieController : Controller
    {
        IRepository<Movie> repo = new ConcreteRepo<Movie>();

        // GET: All Movies
        public ActionResult Index()
        {
            var data = repo.GetAll();
            return View(data);
        }

        // CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            repo.Insert(m);
            repo.Save();
            return RedirectToAction("Index");
        }

        // EDIT
        public ActionResult Edit(int id)
        {
            var data = repo.GetById(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            repo.Update(m);
            repo.Save();
            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index");
        }

        // Movies by Year
        public ActionResult MoviesByYear(int? year)
        {
            if (year == null)
            {
                return Content("Please provide year like ? year=2023");
            }

            var data = repo.GetAll()
                           .Where(x => x.DateOfRelease.Year == year)
                           .ToList();

            return View(data);
        }

        //Movies by director
        public ActionResult MoviesByDirector(string director)
        {
            if (string.IsNullOrWhiteSpace(director))
            {
                return Content("Please provide Director name like ?director=Atlee");
            }

            var data = repo.GetAll()
                           .Where(x => x.DirectorName.Trim().ToLower() == director.Trim().ToLower())
                           .ToList();

            return View(data);
        }
    }
}