using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrandCircusLmsExample.Models;
using Microsoft.AspNetCore.Identity;
using GrandCircusLmsExample.DAL;
using GrandCircusLmsExample.DAL.Models;

namespace GrandCircusLmsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly GrandCircusLmsExampleContext _context = new GrandCircusLmsExampleContext();
        
        public async Task<IActionResult> Index()
        {
            //How to access user info from the user signed in
            var userExample = await userManager.GetUserAsync(HttpContext.User);
            var email = userExample.UserName;
            var student = _context.Students.Where(x => x.Email == email).FirstOrDefault();

            //map to view model
            var welcomeViewModel = new WelcomeView();
            welcomeViewModel.UserName = email;
            welcomeViewModel.FirstName = student.FirstName;
            welcomeViewModel.DateOfBirth = student.DateOfBirth;
            welcomeViewModel.NumberOfItemsPurchasees = student.ItemsOrdered;
            return View(welcomeViewModel);
        }

        public IActionResult Privacy(WelcomeView viewModel)
        {
            //map from view model to entity model so it can be saved in the DB
            var studentEntity = WelcomeView.mapToStudentEntity(viewModel);
            _context.Students.Add(studentEntity);
            _context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
