
using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Models;
using PrimeStone.Infrastructure.Persistence.Seeds;
using System.Reflection;

namespace PrimeStone.Infrastructure.Persistence
{
    public class PrimeStoneDbContext : DbContext
    {
        public PrimeStoneDbContext()
        {
        }
        public PrimeStoneDbContext(DbContextOptions<PrimeStoneDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<EstudianteCurso> EstudianteCurso { get; set; }
        public DbSet<DoWork> DoWork { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedPrimeStone();
            modelBuilder.SeedDefaultUser();
        }
    }
}
