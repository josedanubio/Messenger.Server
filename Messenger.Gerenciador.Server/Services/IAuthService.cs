using System.Threading.Tasks;
using Messenger.Gerenciador.Server.Models;

namespace Messenger.Gerenciador.Server.Services
{
    public interface IAuthService
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
