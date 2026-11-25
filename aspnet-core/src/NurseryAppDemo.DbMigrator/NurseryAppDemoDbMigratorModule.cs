using NurseryAppDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NurseryAppDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NurseryAppDemoEntityFrameworkCoreModule),
    typeof(NurseryAppDemoApplicationContractsModule)
    )]
public class NurseryAppDemoDbMigratorModule : AbpModule
{
}
