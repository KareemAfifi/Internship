using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniAPI.Models;

namespace UniAPI.Interfaces
{
    interface IEnrollsInterface
    {
        public void enrollstudentincourse(Enroll e);
        public object studentsincourse(int courseid);

        public void delete(Enroll e); 


    }
}
