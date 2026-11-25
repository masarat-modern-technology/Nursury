using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NurseryAppDemo.Data;
using Volo.Abp.DependencyInjection;

namespace NurseryAppDemo.EntityFrameworkCore;

public class EntityFrameworkCoreNurseryAppDemoDbSchemaMigrator
    : INurseryAppDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNurseryAppDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the NurseryAppDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NurseryAppDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
