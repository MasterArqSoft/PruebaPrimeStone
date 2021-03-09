using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrimeStoneDbContext _context;

        public UnitOfWork(PrimeStoneDbContext context)
        {
            _context = context;
            CursoRepository = new CursoRepository(_context);
            DireccionRepository = new DireccionRepository(_context);
            EstudianteCursoRepository = new EstudianteCursoRepository(_context);
            UserRepository = new BaseRepository<User>(_context);
            EstudianteRepository = new BaseRepository<Estudiante>(_context);
            SecurityRepository = new SecurityRepository(_context);
            DoWorkRepository = new DoWorkRepository(_context);
        }

        public ICursoRepository CursoRepository { get; }

        public IDireccionRepository DireccionRepository { get; }

        public IEstudianteCursoRepository EstudianteCursoRepository { get; }

        public IRepository<User> UserRepository { get; }

        public IRepository<Estudiante> EstudianteRepository { get; }

        public ISecurityRepository SecurityRepository { get; }

        public IDoWorkRepository DoWorkRepository { get; }

        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
