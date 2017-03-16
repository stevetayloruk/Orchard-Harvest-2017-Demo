using Microsoft.Extensions.Localization;
using Orchard.Environment.Navigation;
using System;

namespace Orchard.AdditionalSiteSettings
{
    public class AdminMenu : INavigationProvider
    {
        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            T = localizer;
        }

        public IStringLocalizer T { get; set; }
        
        public void BuildNavigation(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            builder.Add(T["Design"], design => design
                    .Add(T["Settings"], settings => settings
                        .Add(T["Additional"], T["Additional"], entry => entry
                            .Action("Index", "Admin", new { area = "Orchard.Settings", groupId = "additional" })
                            .LocalNav()
                        )));
        }
    }
}
