using Volo.Abp.Modularity;

namespace NurseryAppDemo;

[DependsOn(
    typeof(NurseryAppDemoApplicationModule),
    typeof(NurseryAppDemoDomainTestModule)
)]
public class NurseryAppDemoApplicationTestModule : AbpModule
{

}
