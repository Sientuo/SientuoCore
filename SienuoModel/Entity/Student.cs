using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SienuoModel
{
    public class Student
    {
        //编号
        public  string Id { get; set; }

        //用户编号
        public string SUserCode { get; set; }
        //用户姓名
        public string SName { get; set; }
        //班级编号
        public string ClassId { get; set; }
        //性别
        public int Sex { get; set; }
        public string CreateBy { get; set; }

        //密码
        public string SPassword { get; set; }

        //创建时间
        public DateTime CreateDate { get; set; }

    }
}
