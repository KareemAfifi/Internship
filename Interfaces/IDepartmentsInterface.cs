using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface IDepartmentsInterface
    {
        public void insertdepartment(Department s);
        public void deletedepartment(Department s);

        public Department getdepartmentbyid(int id);
        public void updatedepartment(Department s);
        public List<Department> getalldepartments();

    }
}
