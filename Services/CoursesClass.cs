using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{
    public class CoursesClass : ICourseInterface
    {
        TrainingContext context = new TrainingContext(); 

        public void addcourse(Course model)
        {
            context.Courses.Add(model);
            context.SaveChanges();  

        }

        public void deletecoursebyid(int id)
        {

            ///CHECK HERE
            //Department d = new Department();
            //  d.Depid = id;
            // context.Courses.Remove(d);
            Course d = context.Courses.Where(x => x.Courseid == id).FirstOrDefault();
            //More than 1 ?
            context.Remove(d);
            context.SaveChanges(); 
        }

        public void updatecourse(Course course)
        {
            context.Update(course);
            context.SaveChanges();
        }

        public List<Course> getavailablecourses()
        {
            return context.Courses.ToList(); 

        }

        public int getcredithours(int id)
        {
            Course d = context.Courses.Where(x => x.Courseid == id).FirstOrDefault();
            //Error Here
            return (int)d.Credithours;
            
        }
    }
}
