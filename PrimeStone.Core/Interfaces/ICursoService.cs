using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface ICursoService
    {
        Task<Curso> GetCurso(int id);

        Task InsertPost(Curso curso);

        Task<bool> UpdatePost(Curso curso);

        Task<bool> DeletePost(int id);
    }
}
