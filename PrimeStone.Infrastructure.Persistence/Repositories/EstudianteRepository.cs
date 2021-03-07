using PrimeStone.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Infrastructure.Persistence.Repositories
{
    public class EstudianteRepository : BaseRepository<Estudiante>
    {
        public EstudianteRepository(PrimeStoneDbContext context) : base(context)
        {
        }
    }
}
