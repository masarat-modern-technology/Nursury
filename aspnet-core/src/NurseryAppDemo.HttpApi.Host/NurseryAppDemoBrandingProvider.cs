using Microsoft.Extensions.Localization;
using NurseryAppDemo.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NurseryAppDemo;

[Dependency(ReplaceServices = true)]
public class NurseryAppDemoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NurseryAppDemoResource> _localizer;

    public NurseryAppDemoBrandingProvider(IStringLocalizer<NurseryAppDemoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
