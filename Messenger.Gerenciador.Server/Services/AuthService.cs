extern alias BCryptNext;

using Microsoft.EntityFrameworkCore;
using Messenger.Gerenciador.Server.Data;
using Messenger.Gerenciador.Server.Models;
using BCryptNext::BCrypt.Net;

namespace Messenger.Gerenciador.Server.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateAsync(string username, string senha)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Usuario == username);

            if (!(usuario == null || !BCrypt.Verify(senha, usuario.Senha)))
            {
                usuario.Ultimo_Login_Data = DateTime.Now;
                await _context.SaveChangesAsync();
                return usuario;
            }

            return null;
        }
    }
}
