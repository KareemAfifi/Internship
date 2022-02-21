using System;
using System.Collections.Generic;

#nullable disable

namespace UniAPI.Models
{
    public partial class Enroll
    {
        public int? Studentid { get; set; }
        public int? Courseid { get; set; }
        public int? Instid { get; set; }
        public int Enrollid { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Inst { get; set; }
        public virtual Student Student { get; set; }
    }
}
