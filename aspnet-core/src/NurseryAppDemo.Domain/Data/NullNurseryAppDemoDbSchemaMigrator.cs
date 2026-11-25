using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NurseryAppDemo.Data;

/* This is used if database provider does't define
 * INurseryAppDemoDbSchemaMigrator implementation.
 */
public class NullNurseryAppDemoDbSchemaMigrator : INurseryAppDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
