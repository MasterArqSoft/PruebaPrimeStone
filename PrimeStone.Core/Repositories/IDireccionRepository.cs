using PrimeStone.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface IDireccionRepository : IRepository<Direccion>
    {
        Task<IEnumerable<Direccion>> GetDireccionByStudent(int studentId);
    }
}
