﻿using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
               name: "DefaultApiWithId", 
               routeTemplate : "Api/{controller}/{id}", 
               defaults: new { id = RouteParameter.Optional }, 
               constraints: new { id = @"\d+" });

            config.Routes.MapHttpRoute(
              name: "DefaultApiWithAction",
              routeTemplate: "Api/{controller}/{action}"
             );

            config.Routes.MapHttpRoute(
              name: "DefaultApiGet",
              routeTemplate: "Api/{controller}",
              defaults: new { action = "Get" },
              constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Get)});

            config.Routes.MapHttpRoute(
              name: "DefaultApiPost",
              routeTemplate: "Api/{controller}",
              defaults: new { action = "Post" },
              constraints: new { httpMethod = new HttpMethodConstraint(HttpMethod.Post)});
        }
    }
}
