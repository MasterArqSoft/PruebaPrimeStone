using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Threading.Tasks;

namespace PrimeStone.Core.Service
{
    public class CursoService : ICursoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CursoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteCurso(int id)
        {
            await _unitOfWork.CursoRepository.DeleteAsync(id).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<Curso> GetCurso(int id)
        {
            return await _unitOfWork.CursoRepository.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task InsertCurso(Curso curso)
        {
            await _unitOfWork.CursoRepository.AddAsync(curso).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateCurso(Curso curso)
        {
            var existingCurso = await _unitOfWork.CursoRepository.GetByIdAsync(curso.Id).ConfigureAwait(false);
            existingCurso.FechaFin = curso.FechaFin;
            existingCurso.FechaInicio = curso.FechaInicio;

            _unitOfWork.CursoRepository.Update(existingCurso);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }
    }
}
