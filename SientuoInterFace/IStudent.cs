using SienuoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SientuoInterFace
{
    public interface IStudent
    {
        Student GetStudent(string code);
    }
}
