using Microsoft.EntityFrameworkCore;

namespace Shared.Instrastructure
{
    public class Repository<Tkey, T> : IRepository<Tkey, T> where T : Entity<Tkey>
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task Delete(Tkey id)
        {
            var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id!.Equals(id));
            if (entity == null)
            {
                return;
            }
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task Delete(List<Tkey> ids)
        {
            if (ids == null || ids.Count == 0) return;
            var entities = await _dbContext.Set<T>().Where(x => ids.Contains(x.Id)).ToListAsync();
            if (entities.Count > 0)
            {
                _dbContext.Set<T>().RemoveRange(entities);
            }
        }

        public async Task<T?> Get(Tkey id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id!.Equals(id));
        }

        public async Task<List<T>> GetByIds(List<Tkey> ids)
        {
            return await _dbContext.Set<T>().Where(x => ids.Contains(x.Id)).ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await Task.CompletedTask;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }


    public class Repository<T> : Repository<long, T> where T : Entity<long>
    {
        public Repository(DbContext dbContext) : base(dbContext)
        {
        }
    }

}
