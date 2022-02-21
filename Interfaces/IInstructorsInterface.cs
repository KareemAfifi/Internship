using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface IInstructorsInterface
    {
        public void addinstructor(Instructor model);

        public List<Instructor> getallinstructors();

        public void deleteinstructor(Instructor model);

        public void updateInstructor(Instructor model); 


    }
}
