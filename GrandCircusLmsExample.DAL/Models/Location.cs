using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public class Location
    { 
        //this is the SQL Id colmun
        public int Id { get; set; }
        //this is the name column
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
