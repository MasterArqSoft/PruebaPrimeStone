using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Threading.Tasks;

namespace PrimeStone.Core.Service
{
    public class DireccionService : IDireccionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DireccionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeleteDireccion(int id)
        {
            await _unitOfWork.DireccionRepository.DeleteAsync(id).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<Direccion> GetDireccion(int id)
        {
            return await _unitOfWork.DireccionRepository.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task InsertDireccion(Direccion direccion)
        {
            await _unitOfWork.DireccionRepository.AddAsync(direccion).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateDireccion(Direccion direccion)
        {
            _unitOfWork.DireccionRepository.Update(direccion);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }
    }
}
