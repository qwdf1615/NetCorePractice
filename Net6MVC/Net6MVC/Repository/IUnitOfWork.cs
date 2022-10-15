namespace Net6MVC.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();

        IRepository<T> Repository<T>() where T : class;
    }
}
