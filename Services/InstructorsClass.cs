using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{
    public class InstructorsClass : IInstructorsInterface
    {
        TrainingContext context = new TrainingContext(); 

        public void addinstructor(Instructor model)
        {
            context.Instructors.Add(model);
            context.SaveChanges(); 
           
        }

        public void deleteinstructor(Instructor model)
        {
            context.Instructors.Remove(model); 
            context.SaveChanges();
        }

        public List<Instructor> getallinstructors()
        {
            List<Instructor> instructors = context.Instructors.ToList();
            return instructors; 
        }

        public void updateInstructor(Instructor model)
        {
            context.Instructors.Add(model);
            context.SaveChanges();

        }
    }
}
