using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface IDireccionService
    {
        Task<Direccion> GetDireccion(int id);

        Task InsertDireccion(Direccion direccion);

        Task<bool> UpdateDireccion(Direccion direccion);

        Task<bool> DeleteDireccion(int id);
    }
}
