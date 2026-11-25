using System;
using System.Collections.Generic;
using System.Text;
using NurseryAppDemo.Localization;
using Volo.Abp.Application.Services;

namespace NurseryAppDemo;

/* Inherit your application services from this class.
 */
public abstract class NurseryAppDemoAppService : ApplicationService
{
    protected NurseryAppDemoAppService()
    {
        LocalizationResource = typeof(NurseryAppDemoResource);
    }
}
