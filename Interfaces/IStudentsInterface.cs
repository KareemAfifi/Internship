using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface IStudentsInterface
    {
        public void insertinto(Student s);
        public void deletestudent(Student s);
   
        public Student getstudentbyid(int id);
        public void updatestudent(Student s);
        public List<Student> getallstudent();
            



    }
}
