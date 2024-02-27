using Dm;
using SientuoIDLL;
using SienuoModel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SientuoDLL
{
    public class StudentDLL:DataBase
    {
        public StudentDLL(ISqlSugarClient client) : base(client)
        {

        }

        public Student GetStudent(string code)
        {
            string sql = $" select * from student where susercode = '{code}'";

            return _db.SqlQueryable<Student>(sql).First();
        }
    }
}