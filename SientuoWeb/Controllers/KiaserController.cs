using Autofac;
using Microsoft.AspNetCore.Mvc;
using SientuoComm.Helper;
using SientuoIDLL;
using SientuoInterFace;
using SientuoService;
using SientuoWeb.Utility;
using System.ComponentModel;
using System.Reflection;

namespace SientuoWeb.Controllers
{
    public class KiaserController: Controller
    {
        private readonly IManData _manData;
        private readonly IPerson _person;
        private readonly IStudent _student;
        public KiaserController(IManData manData, IPerson person,IStudent student) 
        {
            _manData = manData;
            _person = person;
            _student = student;
        }


        [CustomResourceFilter]
        public IActionResult Index()
        {

            ViewData["Kiaser2"] = _person.IsDrink();
            TempData["Kiaser3"] = _student.GetStudent("1111").SName;
            object Kiaser4 = "我是哈哈哈";

            ViewBag.Kiaser1 = _manData.GetName();
            LogHelper.WriteInfo("这是我的第一个core日志");

            return View(Kiaser4);
        }

        //[TypeFilter(typeof(CustomExceptionFilterAttribute))]
        public IActionResult XXX() 
        {
            //这厮一个笑话
            int a = 0;
            int c = 5 / a;
            return View();
        }


    }
}
