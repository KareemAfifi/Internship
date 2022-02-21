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
    public class InstructorteachescourseController : ControllerBase
    {
        InstructorteachescourseClass i = new InstructorteachescourseClass();

        [HttpPost]
        public void Add(Instructorteachescourse model)
        {
            i.Add(model);
        }

        [HttpGet]
        public List<string> CoursesTeachedBy(int instid)
        {
            return i.coursesteachedby(instid);
        }


        [HttpGet]
        [Route("{id}")]
        public List<Instructor> GetInstructorsOfCourse(int id) //course id
        {
            return i.getinstructorsofcourse(id);
        }

        [HttpGet]
        [Route("{id}")]

        public  List<string> GetCourseName(int id)
        {
             return i.getcoursename(id);
        }
        [HttpGet]
        [Route("{id}")]

        public List<string> GetCoursesEnrolledByStudent(int id)
        {
            return i.getcoursesenrolledbystudent(id);
        }
        



    }
}
