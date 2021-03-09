using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class EstudianteCursoRepository : Repository<EstudianteCurso>, IEstudianteCursoRepository
    {
        public EstudianteCursoRepository(PrimeStoneDbContext context):base(context)
        {
        }

        public async Task<IEnumerable<EstudianteCurso>> GetEstudianteCursoByidCurso(int idCurso)
        {
            return await _entities.Where(x => x.CursoId == idCurso).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<EstudianteCurso>> GetEstudianteCursoByIdEstudiante(int idEstudiante)
        {
            return await _entities.Where(x => x.EstudianteId == idEstudiante).ToListAsync().ConfigureAwait(false);
        }

        public async Task<EstudianteCurso> GetByEstudianteCurso(int idEstudiante, int idCurso)
        {
            return await _entities.Where(x => x.EstudianteId == idEstudiante
                                           && x.CursoId == idCurso
                                         )
                                        .FirstOrDefaultAsync().ConfigureAwait(false);
        }
    }
}
