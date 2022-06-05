using Microsoft.EntityFrameworkCore;
using ProjectAlta.DBContext;

namespace ProjectAlta
{
    public static class Connect
    {
        public static IServiceCollection ServicesCollection(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString("ProjectAltaContext"),
               x => x.MigrationsAssembly(typeof(Context).Assembly.FullName)), ServiceLifetime.Transient);

            return service;
        }
    }
}
