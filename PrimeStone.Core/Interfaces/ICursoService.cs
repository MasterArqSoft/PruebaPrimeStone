using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface ICursoService
    {
        Task<Curso> GetCurso(int id);

        Task InsertCurso(Curso curso);

        Task<bool> UpdateCurso(Curso curso);

        Task<bool> DeleteCurso(int id);
    }
}
