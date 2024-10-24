using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication3.App_Start;

namespace WebApplication3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 구성 및 서비스
           
            // Web API 경로
            config.MapHttpAttributeRoutes();
            SwaggerConfig.Register();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
