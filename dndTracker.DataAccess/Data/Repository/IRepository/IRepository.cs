
using System.Linq.Expressions;

namespace dndTracker.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Character
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}