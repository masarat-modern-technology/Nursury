using Volo.Abp.Modularity;

namespace NurseryAppDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class NurseryAppDemoDomainTestBase<TStartupModule> : NurseryAppDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
