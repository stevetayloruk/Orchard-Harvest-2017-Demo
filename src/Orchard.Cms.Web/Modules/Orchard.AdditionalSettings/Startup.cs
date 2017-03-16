using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Modules;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Orchard.Settings.Services;
using Orchard.AdditionalSiteSettings.Drivers;
using Orchard.Environment.Navigation;

namespace Orchard.AdditionalSiteSettings
{
    /// <summary>
    /// These services are registered on the tenant service collection
    /// </summary>
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, AdminMenu>();
            services.AddScoped<ISiteSettingsDisplayDriver, AdditionalSettingsDisplayDriver>();
        }

        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
        }
    }
}
