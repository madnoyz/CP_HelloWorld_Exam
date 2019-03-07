//-----------------------------------------------------------------------
// <copyright file="HelloWorldApiConfig.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HelloWorldProgram.HelloWorldApi.Configuration
{
    /// <summary>
    ///     HelloWorldApiConfig sets up the Web API. 
    /// </summary>
    public static class HelloWorldAPIConfig
    {
        /// <summary>
        ///     Registers and configures the web api routes. 
        /// </summary>
        /// <param name="args"></param>
        public static void Register(HttpConfiguration config)
        {
            // Create Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "HelloWorldApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}