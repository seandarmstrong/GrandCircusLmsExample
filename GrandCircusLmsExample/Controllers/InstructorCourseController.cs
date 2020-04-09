using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandCircusLmsExample.DAL;
using GrandCircusLmsExample.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrandCircusLmsExample.Controllers
{
    public class InstructorCourseController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new GrandCircusLmsExampleContext())
            {
                var data = context.Instructors
                    .Include(x => x.InstructorCourses).ThenInclude(y => y.Course)
                    .ToList();
                return View(data);
            }
        }

        public IActionResult Create(string lastName, string courseName)
        {
            var context = new GrandCircusLmsExampleContext();
            var instructor = context.Instructors.Where(x => x.LastName == lastName).FirstOrDefault();
            var course = context.Courses.Where(c => c.Name == courseName).FirstOrDefault();
            instructor.InstructorCourses = new List<InstructorCourse>
            {
                new InstructorCourse
                {
                    Instructor = instructor,
                    Course = course
                }
            };
            context.Instructors.Update(instructor);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Enrollments()
        {
            var context = new GrandCircusLmsExampleContext();
            var data = context.Enrollments.Where(x => x.CourseId == 1).Include(y => y.Student).ToList();
            return View();
        }
    }
}