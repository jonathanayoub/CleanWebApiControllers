using Swashbuckle.Application;
using System;
using System.Web.Http;

namespace DirtyWebApiControllers.App_Start
{
    /// <summary>
    /// Represents route configuration.
    /// </summary>
    public static class RouteConfig
    {
        /// <summary>
        /// Configures Web API routes.
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configure(HttpConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            configuration.MapHttpAttributeRoutes();
        }
    }
}