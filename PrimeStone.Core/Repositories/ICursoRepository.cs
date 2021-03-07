using PrimeStone.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<IEnumerable<Curso>> GetCursoByCode(string codigoCurso);
    }
}
