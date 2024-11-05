using System.Threading.Tasks;
using BomPraCredito.Domain.Entities;

namespace BomPraCredito.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task CreateUserAsync(User user);
    }
}
