using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public class Instructor : Person
    {
        public string OfficeNumber { get; set; }
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
