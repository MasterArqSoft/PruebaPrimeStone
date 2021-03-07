using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class DireccionRepository : BaseRepository<Direccion>, IDireccionRepository
    {
        public DireccionRepository(PrimeStoneDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Direccion>> GetDireccionByStudent(int studentId)
        {
            return await _entities.Where(x => x.EstudianteId == studentId).ToListAsync().ConfigureAwait(false);
        }
    }
}
