﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace API_Puesto_Venta
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            HttpConfiguration htttpconfig = GlobalConfiguration.Configuration;
            htttpconfig.Formatters.Remove(htttpconfig.Formatters.XmlFormatter);

        }
    }
}
