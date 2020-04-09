using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandCircusLmsExample.DAL;
using GrandCircusLmsExample.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrandCircusLmsExample.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            List<Location> locations = new List<Location>();
            using(var context = new GrandCircusLmsExampleContext())
            {
                locations = context.Locations.ToList();
            }
            return View(locations);
        }

        public IActionResult Update()
        {
                var context = new GrandCircusLmsExampleContext();
                var location = context.Locations.FirstOrDefault();
                location.Name = "My House";
                var course = context.Courses.Find(2);
                var newCourse = new Course
                {
                    Name = "Example",
                    Credits = 2
                };
                context.Update(location);
                context.Remove(course);
                context.Add(newCourse);
                context.SaveChanges();

            return View();
        }
    }
}