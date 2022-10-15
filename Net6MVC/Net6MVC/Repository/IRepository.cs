using System.Linq.Expressions;

namespace Net6MVC.Repository
{
    public interface IRepository<T>
    {
        void Create(T instance);
        void Update(T instance);
        void Delete(T instance);

        void CreateAsync(T instance);
        void UpdateAsync(T instance);
        void DeleteAsync(T instance);

        T Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        void SaveChanges();
    }
}
