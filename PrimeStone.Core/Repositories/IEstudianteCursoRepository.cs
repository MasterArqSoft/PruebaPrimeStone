using PrimeStone.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface IEstudianteCursoRepository: IRepositoryBase<EstudianteCurso>
    {
        Task<IEnumerable<EstudianteCurso>> GetEstudianteCursoByidCurso(int idCurso);
        Task<IEnumerable<EstudianteCurso>> GetEstudianteCursoByIdEstudiante(int idEstudiante);
        Task<EstudianteCurso> GetByEstudianteCurso(int idEstudiante, int idCurso);
    }
}
