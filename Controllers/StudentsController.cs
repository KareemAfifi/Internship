using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniAPI.Models;
using UniAPI.Services;

namespace UniAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        StudentsClass s = new StudentsClass();

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            List<Student> students = s.getallstudent();
            return students;

        }
      
        [HttpGet]
        [Route("{id}")]
        public Student GetStudentById(int id)
        {
           Student student = s.getstudentbyid(id);
            return student;

        }

        [HttpPost]
        public void AddStudent(Student model)
        {
            s.insertinto(model);
    
        }

        [HttpPut]
        public void UpdateStudent(Student model)
        {
            s.updatestudent(model);


        }

        [HttpDelete]
        public void DeleteStudent(Student model)
        {
            s.deletestudent(model);

        }


        


    }
}
