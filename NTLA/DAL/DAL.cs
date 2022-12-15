using NTLA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTLA.DAL
{
    class DAL : subDAL
    {
        CSDL db = new CSDL();
        public static DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static DAL _Instance;
        private DAL()
        {

        }

        public List<Student> GetStudents(int class_ID)
        {
            List<Student> students = new List<Student>();
            if (class_ID == 0)
            {
                students = db.Students.Select(p => p).ToList();
            }
            else
            {
                students = db.Students.Where(p => p.Class_ID == class_ID).ToList();
            }
            return students;
        }
        
        public List<Class> GetClasses()
        {
            var classes = db.Classes.Select(p => p).ToList();
            return classes;
        }

      
      

     

      

        public List<string> GetStudentProperty()
        {
            List<string> properties = new List<string>();
            Student student = new Student();
            foreach (var p in student.GetType().GetProperties())
            {
                properties.Add(p.Name);
            }
            properties.RemoveAt(properties.Count - 2);
            return properties;
        }

       
    }
}
