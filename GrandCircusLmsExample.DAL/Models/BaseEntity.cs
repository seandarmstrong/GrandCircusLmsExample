using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
