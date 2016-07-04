using System.Diagnostics;
using System.Web.Mvc;

namespace WebDeveloper.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"OnActionExecuting controller: { controllerName } action: {actionName}";
            Debug.WriteLine(message, "Action FIlter Log");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"OnActionExecuted controller: { controllerName } action: {actionName}";
            Debug.WriteLine(message, "Action FIlter Log");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"OnResultExecuting controller: { controllerName } action: {actionName}";
            Debug.WriteLine(message, "Action Filter Log");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"OnResultExecuted controller: { controllerName } action: {actionName}";
            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}
