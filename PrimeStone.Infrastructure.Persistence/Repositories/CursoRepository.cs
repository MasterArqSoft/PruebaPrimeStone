using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class CursoRepository : BaseRepository<Curso>, ICursoRepository
    {
        public CursoRepository(PrimeStoneDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Curso>> GetCursoByCode(string codigoCurso)
        {
            return await _entities.Where(x => x.CodigoCurso == codigoCurso).ToListAsync().ConfigureAwait(false);
        }
    }
}
