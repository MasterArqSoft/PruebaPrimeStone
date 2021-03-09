using PrimeStone.Core.Models;
using System;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICursoRepository CursoRepository { get; }
        IDireccionRepository DireccionRepository { get; }
        IRepository<Estudiante> EstudianteRepository { get; }
        IEstudianteCursoRepository EstudianteCursoRepository { get;}
        IRepository<User> UserRepository { get; }
        ISecurityRepository SecurityRepository { get; }
        IDoWorkRepository DoWorkRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
