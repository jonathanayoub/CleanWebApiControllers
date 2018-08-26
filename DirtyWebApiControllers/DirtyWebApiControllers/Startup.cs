﻿using System.Configuration;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using DirtyWebApiControllers.App_Start;

[assembly: OwinStartup(typeof(DirtyWebApiControllers.Startup))]

namespace DirtyWebApiControllers
{
    /// <summary>
    /// Represents the entry point into an application.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Specifies how the ASP.NET application will respond to individual HTTP request.
        /// </summary>
        /// <param name="app">Instance of <see cref="IAppBuilder"/>.</param>
        public void Configuration(IAppBuilder app)
        {
            var corsOptions = CorsConfig.ConfigureCors(ConfigurationManager.AppSettings["cors"]);
            app.UseCors(corsOptions);

            var configuration = new HttpConfiguration();

            FormatterConfig.Configure(configuration);
            RouteConfig.Configure(configuration);
            ServiceConfig.Configure(configuration);

            app.UseWebApi(configuration);
        }
    }
}