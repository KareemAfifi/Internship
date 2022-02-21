using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface ICourseInterface
    {
        public void updatecourse(Course course);
        public List<Course> getavailablecourses();

        public int getcredithours(int courseid);

        public void addcourse(Course model); 

        public void deletecoursebyid(int id); 




    }
}
