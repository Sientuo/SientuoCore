

using SientuoInterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SientuoService
{
    public class PersionService : IPerson
    {
        string IPerson.IsDrink()
        {
            return "Persion";
        }
    }
}
