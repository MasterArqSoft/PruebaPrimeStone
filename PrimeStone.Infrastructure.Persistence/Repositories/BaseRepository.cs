using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Common;
using PrimeStone.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : Entidad
    {
        private readonly PrimeStoneDbContext _context;
        protected readonly DbSet<T> _entities;
        public BaseRepository(PrimeStoneDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id).ConfigureAwait(false);
        }
        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity).ConfigureAwait(false);
        }
        public void AddRange(IEnumerable<T> entity)
        {
            _entities.AddRange(entity);
        }
        public void Update(T entity)
        {
            _entities.Update(entity);
        }
        public async Task DeleteAsync(int id)
        {
            T entity = await GetByIdAsync(id).ConfigureAwait(false);
            _entities.Remove(entity);
        }
        public void DeleteRange(IEnumerable<T> entity)
        {
            _entities.RemoveRange(entity);
        }
    }
}
