using Microsoft.EntityFrameworkCore;
using Net6MVC.Data;
using System.Linq.Expressions;

namespace Net6MVC.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected DbContext _context { get; set; }

        public GenericRepository() : this(new TestDBContext())
        {

        }

        public GenericRepository(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            this._context = context;
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return this._context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Creates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.ArgumentNullException">instance</exception>
        public void Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Add(entity);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// 非同步儲存(需手動Save)
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.ArgumentNullException">instance</exception>
        public void CreateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Add(entity);

            }
        }

        /// <summary>
        /// Updates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Entry(entity).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        /// <summary>
        /// 非同步更新 (需手動Save)
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Entry(entity).State = EntityState.Deleted;
                this.SaveChanges();
            }
        }

        /// <summary>
        /// 非同步刪除 (需手動Save)
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DeleteAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            else
            {
                this._context.Entry(entity).State = EntityState.Deleted;
            }
        }

        /// <summary>
        /// Gets the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return this._context.Set<T>().FirstOrDefault(predicate);
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this._context != null)
                {
                    this._context.Dispose();
                    this._context = null;
                }
            }
        }
    }
}
