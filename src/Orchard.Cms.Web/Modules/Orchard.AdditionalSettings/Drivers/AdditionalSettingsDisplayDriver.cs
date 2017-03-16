using System;
using System.Threading.Tasks;
using Orchard.DisplayManagement.Handlers;
using Orchard.DisplayManagement.ModelBinding;
using Orchard.DisplayManagement.Views;
using Orchard.Settings.Services;
using Orchard.AdditionalSiteSettings.Models;

namespace Orchard.AdditionalSiteSettings.Drivers
{
    public class AdditionalSettingsDisplayDriver : SiteSettingsSectionDisplayDriver<AdditionalSettings>
    {
        public override IDisplayResult Edit(AdditionalSettings section, BuildEditorContext context)
        {
            return Shape<Models.AdditionalSettings>("AdditionalSettings_Edit", model =>
                {
                    model.Subtitle = section.Subtitle;

                }).Location("Content:2").OnGroup("additional");
        }

        public override async Task<IDisplayResult> UpdateAsync(AdditionalSettings section, IUpdateModel updater, string groupId)
        {
            if (groupId == "additional")
            {
                var model = new AdditionalSettings();

                await updater.TryUpdateModelAsync(model, Prefix);

                section.Subtitle = model.Subtitle;
            }

            return Edit(section);
        }
    }
}
