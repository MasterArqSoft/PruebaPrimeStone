using PrimeStone.Core.Models;
using PrimeStone.Core.Repositories;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class DoWorkRepository : Repository<DoWork>, IDoWorkRepository
    {
        public DoWorkRepository(PrimeStoneDbContext context) : base(context)
        {
        }
    }
}
