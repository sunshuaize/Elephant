using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace Elephent.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabaseAccessor(options =>
        {
            options.AddDbPool<DefaultDbContext>();
        }, "Elephent.Database.Migrations");
    }
}
