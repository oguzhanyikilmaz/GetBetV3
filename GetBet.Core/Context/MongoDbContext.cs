using GetBet.Core.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GetBet.Core.Context
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        public MongoDbContext(MongoSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.Database);
        }
        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.Trim());
        }
        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
