using System.Threading.Tasks;
using BomPraCredito.Domain.Entities;
using BomPraCredito.Domain.Interfaces;
using MongoDB.Driver;

namespace BomPraCredito.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserRepository(MongoDBContext context)
        {
            _usersCollection = context.UsersCollection;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _usersCollection.Find(u => u.Username == username).FirstOrDefaultAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _usersCollection.InsertOneAsync(user);
        }
    }
}
