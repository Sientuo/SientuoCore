using Microsoft.Extensions.Configuration;
using SienuoModel;
using SqlSugar;
using System.Configuration;

namespace SientuoDLL
{
    public  class SqlSugarUtil
    {
        //public static  SqlSugarClient SqlSugarClient
        //{
           
        //    get
        //    {
        //        return new SqlSugarClient(new ConnectionConfig()
        //        {
        //            //DbType = SetDBType(ConfigurationManager.AppSettings["DBType"]), //配置数据库类型
        //            //ConnectionString= "data source=.;initial catalog=Test;user id=sa;password=sa123066;MultipleActiveResultSets=True;App=EntityFramework",
        //            DbType = SetDBType(GetName("DBType")), //配置数据库类型
        //            ConnectionString = GetName("ConnectionStrings:WriteConnections").ToString(),
        //            IsAutoCloseConnection = true,//设置为true无需使用using或者Close操作，自动关闭连接，不需要手动关闭数据链接
        //            InitKeyType = InitKeyType.SystemTable//默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
        //        });
        //    }
        //}
        //public  static  DbType SetDBType(string dbType)
        //{
        //    DbType DBType;
        //    switch (dbType.ToLower())
        //    {
        //        case "sqlserver":
        //            DBType = DbType.SqlServer;
        //            break;
        //        case "sqlite":
        //            DBType = DbType.Sqlite;
        //            break;
        //        case "mysql":
        //            DBType = DbType.MySql;
        //            break;
        //        default:
        //            DBType = DbType.MySql;
        //            break;
        //    }
        //    return DBType;
        //}


        //public static string GetName(string name)
        //{
        //    ConfigurationBuilder builder = new ConfigurationBuilder();
        //    builder.AddJsonFile("appsettings.json", true, true);
        //    var ConfigRoot = builder.Build();//根节点
        //    var  VVV= ConfigRoot.GetSection(name).Value ?? string.Empty;
        //    return VVV;
          
        //}

    }
}
