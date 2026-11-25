using Volo.Abp.Modularity;

namespace NurseryAppDemo;

public abstract class NurseryAppDemoApplicationTestBase<TStartupModule> : NurseryAppDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
