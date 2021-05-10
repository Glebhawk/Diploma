using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SpacecraftData.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T item);
        Task<bool> Update(T item);
        Task<bool> Delete(int id);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    }
}
