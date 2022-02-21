using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniAPI.Interfaces;
using UniAPI.Models;
using UniAPI.Services;

namespace UniAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase 
    {
        CoursesClass c = new CoursesClass();
        [HttpPost]
        public void AddCourse(Course model)
        {
            c.addcourse(model);
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCourseById(int id)
        {
            c.deletecoursebyid(id);
        }

        [HttpGet]
        public List<Course> GetAvailableCourses()
        {
            return c.getavailablecourses(); 
        }
        [HttpGet]
        public int GetCreditHours(int courseid)
        {
            return c.getcredithours(courseid);
        }
        [HttpPut]
        public void UpdateCourse(Course course)
        {
            c.updatecourse(course);
        }

    }
}
