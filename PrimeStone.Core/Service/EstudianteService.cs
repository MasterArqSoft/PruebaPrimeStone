using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Threading.Tasks;

namespace PrimeStone.Core.Service
{
    public class EstudianteService : IEstudianteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstudianteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteEstudiante(int id)
        {
            await _unitOfWork.EstudianteRepository.DeleteAsync(id).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<Estudiante> GetEstudiante(int id)
        {
            return await _unitOfWork.EstudianteRepository.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task InsertEstudiante(Estudiante estudiante)
        {
            await _unitOfWork.EstudianteRepository.AddAsync(estudiante).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateEstudiante(Estudiante estudiante)
        {
            _unitOfWork.EstudianteRepository.Update(estudiante);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }
    }
}
