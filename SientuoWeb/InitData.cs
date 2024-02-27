using Autofac;
using Autofac.Builder;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using SientuoDLL;
using SientuoIDLL;
using SientuoInterFace;
using SientuoService;
using SqlSugar;
using System.Reflection;

namespace SientuoWeb
{
    public static class InitData
    {
        public static void InitAntoFacDLL(this WebApplicationBuilder builder) 
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(ContainerBuilder => {


                ContainerBuilder.RegisterType<ManService>().As<IManData>();
                ContainerBuilder.RegisterType<PersionService>().As<IPerson>();
                ContainerBuilder.RegisterType<StudentService>().As<IStudent>();
                ContainerBuilder.RegisterType<StudentDLL>().As<IStudentDLL>();
            });

        }


        public static void ConfigurationShow(this WebApplicationBuilder builder) 
        {
            //var list1 = configuration.GetSection("ConnectionStrings");
            //var list2= configuration.GetSection("ConnectionStrings:WriteConnections");
            //var ID = configuration["Id"];
            //var info = configuration["Info"];

            builder.Host.ConfigureContainer<ContainerBuilder>(container =>
            {
                container.Register<ISqlSugarClient>(context =>
                {
                    SqlSugarClient db = new(new ConnectionConfig()
                    {
                        DbType = DbType.SqlServer,
                        IsAutoCloseConnection = true,
                        ConnectionString = builder.Configuration.GetConnectionString("WriteConnections")
                    });
                    return db;
                });
            });

        }
    }
}
