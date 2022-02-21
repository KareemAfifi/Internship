using System;
using System.Collections.Generic;

#nullable disable

namespace UniAPI.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrolls = new HashSet<Enroll>();
        }

        public int Courseid { get; set; }
        public string Coursename { get; set; }
        public int? Credithours { get; set; }
        public int? Depid { get; set; }

        public virtual Department Dep { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
    }
}
