
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
               options.UseSqlServer( connectionString: configuration.GetConnectionString( "PrimeStone" ) ));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICursoService, CursoService>();
            services.AddTransient<IDireccionService, DireccionService>();
            services.AddTransient<IEstudianteService, EstudianteService>();
            services.AddTransient<IEstudianteCursoService, EstudianteCursoService>();
            services.AddTransient<ISecurityService, SecurityService>();
            services.AddTransient<IDoWorkService, DoWorkService>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILogsService, LogsService>();
            services.AddSingleton<IPasswordService, PasswordService>();

            return services;
        }
    }
}
