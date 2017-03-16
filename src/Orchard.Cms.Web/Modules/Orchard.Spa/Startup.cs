using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Modules;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using System.IO;
using Orchard.Settings;

namespace Orchard.Spa
{
    /// <summary>
    /// These services are registered on the tenant service collection
    /// </summary>
    public class Startup : StartupBase
    {
        private IHostingEnvironment _env;
       // private readonly ISiteService _siteService;

        public Startup(IHostingEnvironment env)//, //ISiteService siteService)
        {
            _env = env;
          //  _siteService = siteService;
        }

        public override void ConfigureServices(IServiceCollection services)
        {
         }

        public override void Configure(IApplicationBuilder builder, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            if (_env.IsDevelopment())
            {
                builder.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    ProjectPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName
                });
            }

            //var site = _siteService.GetSiteSettingsAsync().GetAwaiter().GetResult();
            //var homeRoute = site.HomeRoute;


            //routes.MapSpaFallbackRoute(
            //    name: "spa-fallback",
            //    defaults: new { controller = "Item", action = "Display" });

            //routes.MapAreaRoute(
            //    name: "spa-fallback",
            //    areaName: "Orchard.Contents",
            //    template: "*",
            //    defaults: new { controller = "Item", action = "Display" }
            //);

            //// Admin
            //routes.MapAreaRoute(
            //    name: "AdminSettings",
            //    areaName: "Orchard.Settings",
            //    template: "Admin/Settings/{groupId}",
            //    defaults: new { controller = "Admin", action = "Index" }
            //);
        }
    }
}
