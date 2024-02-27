using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SientuoIDLL;
using SientuoInterFace;
using SienuoModel;

namespace SientuoService
{
    public class StudentService : IStudent
    {
        private readonly IStudentDLL _stuLL;

        public StudentService(IStudentDLL student) 
        {
            _stuLL = student;
        }

        public Student GetStudent(string code)
        {
            return _stuLL.GetStudent(code);
        }
    }
}
