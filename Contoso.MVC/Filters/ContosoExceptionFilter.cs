using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace Contoso.MVC.Filters
{
    public class ContosoExceptionFilter :HandleErrorAttribute
    {
        public ContosoExceptionFilter()
        {

        }
        public override void OnException(ExceptionContext filterContext)
        {
            var controllerName =(string) filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
            filterContext.Result = new ViewResult {
                ViewName=View, MasterName=Master,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData= filterContext.Controller.TempData
            };
            string exceptionPath = filterContext.HttpContext.Request.Path + filterContext.HttpContext.Request.QueryString;

            // Log eception information like
            //1.exception 
            //2.Inner Message 
            //3.Date time ->now
            //4. Action method 
            //5 whole stack trace->filter
            //6. exception Path(URL)
            //7. Log above detail using Nlog to text file

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;


            base.OnException(filterContext);
          

        }
    }
}