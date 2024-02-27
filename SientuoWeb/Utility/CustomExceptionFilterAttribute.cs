using Autofac.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SientuoComm.Helper;
using System.Diagnostics.CodeAnalysis;

namespace SientuoWeb.Utility
{
    public class CustomExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly IModelMetadataProvider _IModelMetadataProvider;

        public CustomExceptionFilterAttribute(IModelMetadataProvider modelMetadataProvider)
        {
             _IModelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                //ajax 请求 json
                if (IsAjaxRequest(context.HttpContext.Request)) 
                {
                    context.Result = new JsonResult(new
                    {
                       Success = true,
                       context.Exception.Message,
                    });
                }
                else
                {
                    //界面请求 异常界面
                    ViewResult result = new ViewResult
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                        ViewData = new ViewDataDictionary(_IModelMetadataProvider, context.ModelState)
                    };
                    result.ViewData.Add("Exception", context.Exception);
                    context.Result = result;
                }
            }

            LogHelper.WriteError($"这里有一个异常，{context.Exception.Message}");
        }


        private bool IsAjaxRequest(HttpRequest request) 
        {
            string header =  request.Headers["H-Requested-With"];
            return "XMLHttpRequest".Equals(header, StringComparison.OrdinalIgnoreCase);
        }
    }
}
