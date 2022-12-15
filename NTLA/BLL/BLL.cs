using NTLA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTLA.BLL
{
    class BLL
    {
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static BLL _Instance;
        private BLL()
        {

        }
        public List<Student> GetStudents(int class_ID)
        {
            List<Student> studentViewModels = new List<Student>();
            var students = DAL.DAL.Instance.GetStudents(0);
            foreach (var s in students)
            {
                studentViewModels.Add(new Student
                {
                    ID = s.ID,
                    Name = s.Name,
                    Gender = s.Gender,
                    DateOfBirth = s.DateOfBirth,
                    
                });
            }
            return studentViewModels;
        }
        public List<Class> GetClasses()
        {
            return DAL.DAL.Instance.GetClasses();
        }
        public List<string> GetStudentProperty()
        {
            return DAL.DAL.Instance.GetStudentProperty();
        }
        
       
    }
}
