using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{
    public class EnrollsClass : IEnrollsInterface
    {

        TrainingContext context = new TrainingContext();

        public EnrollsClass()
        {

        }

        public void delete(Enroll e)
        {
            context.Enrolls.Remove(e);
            context.SaveChanges();
        }

        public void enrollstudentincourse(Enroll e)
        {
            context.Enrolls.Add(e);
            context.SaveChanges(); 
            
        }

        public object studentsincourse(int courseid)
        {
            var s = context.Enrolls.Where(x => x.Courseid == courseid).ToList();
            return s;
        }
    }
}
