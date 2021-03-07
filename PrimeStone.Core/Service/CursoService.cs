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

        public async Task<bool> DeletePost(int id)
        {
            await _unitOfWork.CursoRepository.DeleteAsync(id).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<Curso> GetCurso(int id)
        {
            return await _unitOfWork.CursoRepository.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task InsertPost(Curso curso)
        {
            await _unitOfWork.CursoRepository.AddAsync(curso).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdatePost(Curso curso)
        {
            _unitOfWork.CursoRepository.Update(curso);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }
    }
}
