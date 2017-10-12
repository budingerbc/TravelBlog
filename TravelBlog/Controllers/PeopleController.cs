using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {
        public TravelBlogContext db = new TravelBlogContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.People.Include(people => people.Experiences).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Title", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(People people)
        {
            db.People.Add(people);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
