using Messenger.Gerenciador.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messenger.Gerenciador.Server.Services
{
    public interface IAuthService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
        Task<LoginResponse> Authenticate(LoginRequest loginRequest);
    }
}
