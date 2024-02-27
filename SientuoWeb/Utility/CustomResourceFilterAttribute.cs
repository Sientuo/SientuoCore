using Microsoft.AspNetCore.Mvc.Filters;
using SientuoComm.Helper;

namespace SientuoWeb.Utility
{
    public class CustomResourceFilterAttribute : Attribute, IResourceFilter
    {
        void IResourceFilter.OnResourceExecuted(ResourceExecutedContext context)
        {
            LogHelper.WriteInfo("资源后发生");
        }

        void IResourceFilter.OnResourceExecuting(ResourceExecutingContext context)
        {
            LogHelper.WriteInfo("资源前发生");
        }
    }
}
