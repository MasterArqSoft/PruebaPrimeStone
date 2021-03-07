using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface ISecurityRepository : IRepository<Security>
    {
        Task<Security> GetLoginByCredentials(UserLogin login);
    }
}
