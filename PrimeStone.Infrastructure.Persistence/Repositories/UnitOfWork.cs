using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrimeStoneDbContext _context;
        private readonly ICursoRepository _cursoRepository;
        private readonly IDireccionRepository _direccionRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Estudiante> _estudianteRepository;
        private readonly ISecurityRepository _securityRepository;

        public UnitOfWork(
             PrimeStoneDbContext context,
             ICursoRepository cursoRepository,
             IDireccionRepository direccionRepository,
             IRepository<User> userRepository,
             IRepository<Estudiante> estudianteRepository,
              ISecurityRepository securityRepository
            )
        {
            _context = context;
            _cursoRepository = cursoRepository;
            _direccionRepository = direccionRepository;
            _userRepository = userRepository;
            _estudianteRepository = estudianteRepository;
            _securityRepository = securityRepository;
        }

        public ICursoRepository CursoRepository => _cursoRepository ?? new CursoRepository(_context);

        public IDireccionRepository DireccionRepository => _direccionRepository ?? new DireccionRepository(_context);

        public IRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);

        public IRepository<Estudiante> EstudianteRepository => _estudianteRepository ?? new BaseRepository<Estudiante>(_context);

        public ISecurityRepository SecurityRepository => _securityRepository ?? new SecurityRepository(_context);

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
