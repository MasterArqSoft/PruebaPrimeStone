using PrimeStone.Core.Interfaces;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace PrimeStone.Core.Service
{
    public class DoWorkService : IDoWorkService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DoWorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task InsertDoWork(DoWork doWork)
        {
            await _unitOfWork.DoWorkRepository.AddAsync(doWork).ConfigureAwait(false);
            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
