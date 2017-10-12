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
    public class ExperienceController : Controller
    {
        public TravelBlogContext db = new TravelBlogContext();
       
        public IActionResult Index()
        {
            
            return View(db.Experiences.Include(experiences => experiences.Locations).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationCity", "LocationCountry");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience Experience)
        {
            db.Experiences.Add(Experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
