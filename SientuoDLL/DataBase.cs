using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SientuoDLL
{
    public abstract class DataBase
    {
        protected readonly ISqlSugarClient _db;
        protected DataBase(ISqlSugarClient client)
        {
            _db = client;
        }
    }
}
