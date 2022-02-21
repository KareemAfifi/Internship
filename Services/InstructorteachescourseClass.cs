using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{
    public class InstructorteachescourseClass : IInstrcutorteachescourseInterface
    {
        TrainingContext context = new TrainingContext();

        public void Add(Instructorteachescourse model)
        {
            context.Add(model);
            context.SaveChanges();
        }

        public List<string> coursesteachedby(int instid)
        {
            var query = from x in context.Instructorteachescourses
                        from y in context.Courses //on x.Courseid equals y.Courseid 
                        where x.Courseid ==y.Courseid
                        && x.Instid == instid
                        select new
                        {
                            y.Coursename
                        };
            List<string> m = new List<string>();
            foreach (var x in query)
            {
                m.Add(x.Coursename);

            }

            return m.ToList();


        }

        public List<Instructor> getinstructorsofcourse(int courseid)
        {
            var query = from x in context.Instructorteachescourses
                        from y in context.Instructors //on x.Courseid equals y.Courseid 
                        where x.Instid == y.Instid
                        && x.Courseid == courseid
                        select new
                        {
                            y.Instid, 
                            y.FName,
                            y.LName,
                            y.Depid
                        };
            List<Instructor> m = new List<Instructor>();
            foreach (var x in query)
            {
                Instructor k = new Instructor();
                k.Instid = x.Instid;
                k.FName = x.FName;
                k.LName = x.LName;
                k.Depid = x.Depid;
                m.Add(k);
                
            }
            
            return m.ToList();

            
        }

        public List<string> getcoursename(int instid)
        {
            var query = from x in context.Instructorteachescourses
                        from y in context.Courses //on x.Courseid equals y.Courseid 
                        where x.Instid == instid
                        && x.Courseid == y.Courseid
                        select new
                        {
                            y.Coursename
                        };
            List<string> m = new List<string>();
            foreach (var x in query)
            {
                m.Add(x.Coursename);
                
            }
            
            return m.ToList();
          
        }

        public List<string> getcoursesenrolledbystudent(int studentid)
        {
            var query = context.Enrolls.Join(context.Courses, enroll => enroll.Courseid,
                course => course.Courseid, (enroll, course) => new
                {
                    CourseName = course.Coursename,
                    Studentid = enroll.Studentid

                }).Where(r=>r.Studentid==studentid);


            List<string> m = new List<string>();
            foreach (var x in query)
            {
                m.Add(x.CourseName);

            }

            return m.ToList();

        }


    }
}
