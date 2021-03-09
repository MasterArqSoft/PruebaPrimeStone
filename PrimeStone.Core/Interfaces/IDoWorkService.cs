using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface IDoWorkService
    {
        Task InsertDoWork(DoWork doWork);
    }
}
