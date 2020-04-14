using GrandCircusLmsExample.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandCircusLmsExample.Models
{
    public class WelcomeView
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumberOfItemsPurchasees { get; set; }

        public WelcomeView()
        {

        }
        public WelcomeView(string userName)
        {
            this.UserName = userName;
        }

        public static Student mapToStudentEntity(WelcomeView viewModel)
        {
            var student = new Student();
            student.FirstName = viewModel.FirstName;
            return student;
        }
    }
}
