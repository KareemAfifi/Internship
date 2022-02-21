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
    public class DepartmentsController : ControllerBase
    {
        DepartmentsClass s = new DepartmentsClass();

        [HttpGet]
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = s.getalldepartments();
            return departments;

        }

        [HttpGet]
        [Route("{id}")]
        public Department GetDepartmenttById(int id)
        {
            Department dep = s.getdepartmentbyid(id);
            return dep;

        }

        [HttpPost]
        public void AddDepartment(Department model)
        {
            s.insertdepartment(model);

        }

        [HttpPut]
        public void UpdateDepartment(Department model)
        {
            s.updatedepartment(model);


        }

        [HttpDelete]
        public void DeleteDepartment(Department model)
        {
            s.deletedepartment(model);

        }




    }
}
