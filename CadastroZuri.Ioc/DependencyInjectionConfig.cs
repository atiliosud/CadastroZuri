using CadastroZuri.Business.Contracts.Repositories;
using CadastroZuri.Business.Contracts.Services;
using CadastroZuri.Business.Services;
using CadastroZuri.Repository.Data;
using CadastroZuri.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CadastroZuri.Ioc
{
    public static class DependencyInjectionConfig
    {
        public static IServiceProvider ApplyDependencies(this IServiceProvider app)
        {

            using (var scope = app.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ZuriDbContext>();
                db.Database.Migrate();
            }
            return app;
        }

        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ZuriDbContext>(options => {
                options.UseSqlServer(connectionString,
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 3,
                            maxRetryDelay: TimeSpan.FromSeconds(5),
                            errorNumbersToAdd: null);
                    });
            });

            

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            return services;
        }

    }
}