using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface IEstudianteService
    {
        Task<Estudiante> GetEstudiante(int id);

        Task InsertEstudiante(Estudiante estudiante);

        Task<bool> UpdateEstudiante(Estudiante estudiante);

        Task<bool> DeleteEstudiante(int id);
    }
}
