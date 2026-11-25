using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NurseryAppDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NurseryAppDemoDbContextFactory : IDesignTimeDbContextFactory<NurseryAppDemoDbContext>
{
    public NurseryAppDemoDbContext CreateDbContext(string[] args)
    {
        NurseryAppDemoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NurseryAppDemoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new NurseryAppDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NurseryAppDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
