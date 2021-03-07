using PrimeStone.Core.Models;
using System.Threading.Tasks;

namespace PrimeStone.Core.Interfaces
{
    public interface ISecurityService
    {
        Task<Security> GetLoginByCredentials(UserLogin userLogin);
        Task RegisterUser(Security security);
    }
}
