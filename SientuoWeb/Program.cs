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
                option.Filters.Add<CustomExceptionFilterAttribute>();
            });

            builder.Logging.AddNLog("NLog/NLog.config");

            builder.InitAntoFacDLL();

            InitData.ConfigurationShow(builder);


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
