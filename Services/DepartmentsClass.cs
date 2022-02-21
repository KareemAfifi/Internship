using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Interfaces;
using UniAPI.Models;

namespace UniAPI.Services
{
    public class DepartmentsClass : IDepartmentsInterface
    {
        private readonly TrainingContext context = new TrainingContext();

        public DepartmentsClass()
        {

        }

        public void deletedepartment(Department model)
        {
            context.Departments.Remove(model);
            context.SaveChanges();
        }

        public List<Department> getalldepartments()
        {
            List<Department> listofdepartments = context.Departments.ToList();
            return listofdepartments;
        }

        public Department getdepartmentbyid(int id)
        {
            Department s = context.Departments.Where(x => x.Depid == id).FirstOrDefault();
            return s;
        }

        public void insertdepartment(Department s)
        {
            context.Departments.Add(s);
            context.SaveChanges();
        }

        public void updatedepartment(Department s)
        {
            context.Departments.Update(s);
            context.SaveChanges();

        }
    }
}
