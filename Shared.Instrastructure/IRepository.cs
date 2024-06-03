namespace Shared.Instrastructure
{
    public interface IRepository<TKey, T> : IUnitWork where T : Entity<TKey>
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(TKey id);

        Task Delete(List<TKey> ids);

        Task<T?> Get(TKey id);

        Task<List<T>> GetByIds(List<TKey> ids);
    }


    public interface IRepository<T> : IRepository<long, T> where T : Entity<long>
    {

    }

    public interface IUnitWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

}
