using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public class Student : Person   
    {
        public string DeclaredMajor { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
