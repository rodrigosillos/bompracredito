using MongoDB.Driver;
using BomPraCredito.Domain.Entities;
using BomPraCredito.Domain.Configurations;

namespace BomPraCredito.Infrastructure
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(MongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<User> UsersCollection => _database.GetCollection<User>("Users");
    }
}
