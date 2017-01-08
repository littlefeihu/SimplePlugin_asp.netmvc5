using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacMvc5Test
{
    public class MyPathProviderViewEngine:VirtualPathProviderViewEngine
    {
        public MyPathProviderViewEngine()
        {
           
            MasterLocationFormats = new[]  {
                                                //Admin
                                                "~/WebAdmin/Views/{1}/{0}.cshtml",
                                                "~/WebAdmin/Views/Shared/{0}.cshtml",
                                             };

            ViewLocationFormats = MasterLocationFormats;

            PartialViewLocationFormats = MasterLocationFormats;
        }
        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            IEnumerable<string> fileExtensions = base.FileExtensions;
            return new RazorView(controllerContext, partialPath, null, false, fileExtensions);
            //return new RazorView(controllerContext, partialPath, layoutPath, runViewStartPages, fileExtensions, base.ViewPageActivator);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            IEnumerable<string> fileExtensions = base.FileExtensions;
            return new RazorView(controllerContext, viewPath, masterPath, true, fileExtensions);
        }
    }
}