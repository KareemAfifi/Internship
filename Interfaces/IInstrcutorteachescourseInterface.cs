using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface IInstrcutorteachescourseInterface
    {
        public List<Instructor  > getinstructorsofcourse(int courseid);

        public List<string> coursesteachedby(int instid);

        public void Add(Instructorteachescourse model);
        public List<string> getcoursesenrolledbystudent(int id);

        public List<string> getcoursename(int id);

    }
}
