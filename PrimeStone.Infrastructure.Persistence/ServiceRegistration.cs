using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Repositories;
using PrimeStone.Core.SecurityService;
using PrimeStone.Core.Service;
using PrimeStone.Infrastructure.Persistence.Repositories;

namespace PrimeStone.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PrimeStoneDbContext>(options =>
               options.UseSqlServer(connectionString: configuration.GetConnectionString("PrimeStone"),
               b => b.MigrationsAssembly(typeof(PrimeStoneDbContext).Assembly.FullName))
           );

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<IEstudianteService, EstudianteService>();
            services.AddScoped<IDireccionService, DireccionService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IPasswordService, PasswordService>();

            return services;
        }
    }
}
