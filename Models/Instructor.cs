using System;
using System.Collections.Generic;

#nullable disable

namespace UniAPI.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Enrolls = new HashSet<Enroll>();
        }

        public int Instid { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int? Depid { get; set; }

        public virtual Department Dep { get; set; }
        public virtual ICollection<Enroll> Enrolls { get; set; }
    }
}
