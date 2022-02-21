using System;
using System.Collections.Generic;

#nullable disable

namespace UniAPI.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrolls = new HashSet<Enroll>();
        }

        public int Studentid { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public DateTime? Dob { get; set; }
        public decimal? Gpa { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }
    }
}
