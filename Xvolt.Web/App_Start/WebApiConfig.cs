﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Xvolt.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/1.0/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
