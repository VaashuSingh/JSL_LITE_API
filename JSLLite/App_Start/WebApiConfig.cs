using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BeatAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.MapHttpAttributeRoutes();
            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            //var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            config.Formatters.Remove(config.Formatters.XmlFormatter); 
        }
    }
}
