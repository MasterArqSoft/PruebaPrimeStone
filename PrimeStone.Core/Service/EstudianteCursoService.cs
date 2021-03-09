using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeStone.Core.Service
{
    public class EstudianteCursoService : IEstudianteCursoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstudianteCursoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeletetByEstudianteCurso(int idEstudiante, int idCurso)
        {
            var existeEstudianteCurso =  await GetEstudianteCurso(idEstudiante, idCurso).ConfigureAwait(false);
             _unitOfWork.EstudianteCursoRepository.Delete(existeEstudianteCurso);
            return true;
        }

        public async Task<IEnumerable<EstudianteCurso>> GetByIdCurso(int idCurso)
        {
            return await _unitOfWork.EstudianteCursoRepository.GetEstudianteCursoByidCurso(idCurso).ConfigureAwait(false);
        }

        public async Task<IEnumerable<EstudianteCurso>> GetByIdEstudiante(int idEstudiante)
        {
           return await _unitOfWork.EstudianteCursoRepository.GetEstudianteCursoByIdEstudiante(idEstudiante).ConfigureAwait(false);
        }

        public async Task<EstudianteCurso> GetEstudianteCurso(int idCurso, int idEstudiante)
        {
             return await _unitOfWork.EstudianteCursoRepository
                                                 .GetByEstudianteCurso(idEstudiante, idCurso)
                                                 .ConfigureAwait(false);
        }

        public async Task InsertEstudianteCurso(EstudianteCurso estudianteCurso)
        {
            await _unitOfWork.EstudianteCursoRepository.AddAsync(estudianteCurso).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateEstudianteCurso(EstudianteCurso estudianteCurso)
        {
            var existingEstudianteCurso = await GetEstudianteCurso(estudianteCurso.EstudianteId, estudianteCurso.CursoId).ConfigureAwait(false);
            existingEstudianteCurso.CursoId = estudianteCurso.CursoId;

            _unitOfWork.EstudianteCursoRepository.Update(existingEstudianteCurso);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }
    }
}
