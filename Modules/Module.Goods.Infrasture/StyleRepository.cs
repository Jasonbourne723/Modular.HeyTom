using Module.Goods.Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Goods.Infrasture
{
    public class StyleRepository : IStyleRepository
    {
        private readonly IMongoCollection<Style> _mongoCollection;

        public StyleRepository(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("heytom");

            _mongoCollection = database.GetCollection<Style>("Style");
        }

        public async Task Add(Style entity)
        {
            await _mongoCollection.InsertOneAsync(entity);
        }

        public async Task Delete(long id)
        {
            await _mongoCollection.DeleteOneAsync(x => x.Id == id);
        }

        public async Task Delete(List<long> ids)
        {
            await _mongoCollection.DeleteManyAsync(x => ids.Contains(x.Id));
        }

        public async Task<Style?> Get(long id)
        {
            return await _mongoCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Style>> GetByIds(List<long> ids)
        {
            return await _mongoCollection.Find(x => ids.Contains(x.Id)).ToListAsync();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(0);
        }

        public async Task Update(Style entity)
        {
            await _mongoCollection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
        }
    }
}
