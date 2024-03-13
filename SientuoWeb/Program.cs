using Microsoft.Extensions.Options;
using NLog.Web;
using SientuoWeb.Utility;

namespace SientuoWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(option => {
                //异常控制器过滤
                option.Filters.Add<CustomExceptionFilterAttribute>();
            });
            //日志注入
            builder.Logging.AddNLog("NLog/NLog.config");
            //依赖注入
            builder.InitAntoFacDLL();
            //Db相关注入
            builder.ConfigurationShow();

            var app = builder.Build();

            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Kiaser}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
