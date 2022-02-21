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
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollsController : ControllerBase
    {
        EnrollsClass m = new EnrollsClass();

        [HttpPost]
        public void InsertIntoEnroll(Enroll e)
        {
            m.enrollstudentincourse(e);
        }
        [HttpGet]
        [Route("{id}")]
        public object StudentstInCourse(int id) //course id
        {
           return m.studentsincourse(id);
        }
        [HttpDelete]
        public void Delete(Enroll e)
        {
            m.delete(e);
        }


    }
}
