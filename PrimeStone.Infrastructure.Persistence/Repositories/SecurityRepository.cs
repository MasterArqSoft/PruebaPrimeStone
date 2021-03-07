using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class SecurityRepository : BaseRepository<Security>, ISecurityRepository
    {
        public SecurityRepository(PrimeStoneDbContext context) : base(context) { }

        public async Task<Security> GetLoginByCredentials(UserLogin login)
        {
            return await _entities.FirstOrDefaultAsync(x => x.User == login.User).ConfigureAwait(false);
        }
    }
}
