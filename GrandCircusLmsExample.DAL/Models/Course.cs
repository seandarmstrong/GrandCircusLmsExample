using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public int LocationId { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
