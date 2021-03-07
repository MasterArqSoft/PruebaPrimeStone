using PrimeStone.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStone.Core.Repositories
{
    public interface IRepository<T> where T : Entidad

    {
        IEnumerable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        void AddRange(IEnumerable<T> entity);

        void Update(T entity);

        Task DeleteAsync(int id);

        void DeleteRange(IEnumerable<T> entity);
    }
}
