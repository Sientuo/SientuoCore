using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SienuoModel
{
    public class Student
    {
        public  string Id { get; set; }

        public string SUserCode { get; set; }

        public string SName { get; set; }
        public string ClassId { get; set; }
        public int Sex { get; set; }
        public string CreateBy { get; set; }

        public string SPassword { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
