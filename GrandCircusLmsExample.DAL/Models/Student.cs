using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public class Student : Person   
    {
        public string DeclaredMajor { get; set; }
        public string Email { get; set; }
        public int ItemsOrdered { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
