using AutofacMvc5Test.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacMvc5Test
{
    public abstract class CustomViewPage : WebViewPage
    {
        public ILog Logger { get; set; }
    }
}