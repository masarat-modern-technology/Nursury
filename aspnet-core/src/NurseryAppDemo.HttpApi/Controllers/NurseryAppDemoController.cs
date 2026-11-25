using NurseryAppDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NurseryAppDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NurseryAppDemoController : AbpControllerBase
{
    protected NurseryAppDemoController()
    {
        LocalizationResource = typeof(NurseryAppDemoResource);
    }
}
