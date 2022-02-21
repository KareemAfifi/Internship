using System;
using System.Collections.Generic;

#nullable disable

namespace UniAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
            Instructors = new HashSet<Instructor>();
        }

        public int Depid { get; set; }
        public string Depname { get; set; }
        public string Deploc { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
