using Volo.Abp.Modularity;

namespace NurseryAppDemo;

[DependsOn(
    typeof(NurseryAppDemoDomainModule),
    typeof(NurseryAppDemoTestBaseModule)
)]
public class NurseryAppDemoDomainTestModule : AbpModule
{

}
