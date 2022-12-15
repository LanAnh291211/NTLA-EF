using NTLA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTLA.DAL
{
    interface subDAL
    {
        
        List<Student> GetStudents(int class_ID);
     
        List<Class> GetClasses();

      

        List<string> GetStudentProperty();

        
    }
}
