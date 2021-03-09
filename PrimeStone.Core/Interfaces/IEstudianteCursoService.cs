using PrimeStone.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface IEstudianteCursoService
    {
        Task<IEnumerable< EstudianteCurso>> GetByIdCurso(int idCurso);

        Task<IEnumerable<EstudianteCurso>> GetByIdEstudiante(int idEstudiante);

        Task<EstudianteCurso> GetEstudianteCurso(int idCurso, int idEstudiante);
        Task InsertEstudianteCurso(EstudianteCurso estudianteCurso);

        Task<bool> UpdateEstudianteCurso(EstudianteCurso estudianteCurso);

        Task<bool> DeletetByEstudianteCurso(int idEstudiante, int idCurso);
    }
}
