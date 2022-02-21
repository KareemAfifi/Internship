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
    public class InstructorsController : ControllerBase
    {
        InstructorsClass i = new InstructorsClass(); 
        [HttpPost]
        public void AddInstructor(Instructor model)
        {
            i.addinstructor(model); 

        }

        [HttpDelete]
        public void DeleteInstructor(Instructor model)
        {
            i.deleteinstructor(model);
        }

        [HttpGet]
        public List<Instructor> GetAllInstructors()
        {
            return i.getallinstructors(); 
        }

        [HttpPut]
        public void UpdateInstructor(Instructor model)
        {
            i.updateInstructor(model); 

        }

    }
}
