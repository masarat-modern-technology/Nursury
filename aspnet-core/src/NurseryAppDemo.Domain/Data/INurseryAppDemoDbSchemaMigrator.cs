using System.Threading.Tasks;

namespace NurseryAppDemo.Data;

public interface INurseryAppDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
