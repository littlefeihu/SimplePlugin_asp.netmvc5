using AutofacMvc5Test.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacMvc5Test.Filter
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        public ILog Logger { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Logger.Write("OnActionExecuting");
        }
    }
}