using PrimeStone.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICursoRepository CursoRepository { get; }
        IDireccionRepository DireccionRepository { get; }
        IRepository<Estudiante> EstudianteRepository { get; }
        IRepository<User> UserRepository { get; }
        ISecurityRepository SecurityRepository { get; }
        void SaveChanges();

        Task SaveChangesAsync();
    }
}
