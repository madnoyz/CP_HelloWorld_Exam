//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using HelloWorldProgram.HelloWorldApi.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace HelloWorldApi
{
    /// <summary>
    ///     Global class starts the main web api application. 
    /// </summary>
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(HelloWorldAPIConfig.Register);

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}