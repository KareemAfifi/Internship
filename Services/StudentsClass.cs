using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{

    public class StudentsClass : IStudentsInterface
    {
        private readonly TrainingContext context=   new TrainingContext();

        public StudentsClass(TrainingContext context)
        {

        }
        public StudentsClass()
        {

        }

        public void deletestudent(Student model)
        {
            
            context.Students.Remove(model);
            context.SaveChanges();

        }

        public List<Student> getallstudent()
        {
            List<Student> listofstudents =  context.Students.ToList();
            return listofstudents;
           
        }

        

        public Student getstudentbyid(int id)
        {
            Student s = context.Students.Where(x => x.Studentid ==id).FirstOrDefault();
            return s;
        }

        public void insertinto(Student model)
        {
            Student student1 = new Student();
            {
                student1.Studentid = model.Studentid;
                student1.FName = model.FName;
                student1.MName = model.MName;
                student1.LName = model.LName;
                student1.Gpa = model.Gpa;
                student1.Age = model.Age;
                student1.Dob = model.Dob;

            };
            context.Students.Add(student1);
            context.SaveChanges();
        
        }

        public void updatestudent(Student model)
        {
            Student student1 = new Student();
            {
                student1.Studentid = model.Studentid;
                student1.FName = model.FName;
                student1.MName = model.MName;
                student1.LName = model.LName;
                student1.Gpa = model.Gpa;
                student1.Age = model.Age;
                student1.Dob = model.Dob;

            };
            context.Students.Update(student1);
            context.SaveChanges();

        }

        
    }
}
