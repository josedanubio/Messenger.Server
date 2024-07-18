using Microsoft.AspNetCore.Mvc;
using Messenger.Gerenciador.Server.Models;
using Messenger.Gerenciador.Server.Services;
using System.Threading.Tasks;

namespace Messenger.Gerenciador.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var usuario = await _authService.AuthenticateAsync(loginRequest.Usuario, loginRequest.Senha);

            if (usuario != null)
            {
                return Ok(new { message = "Autenticação bem-sucedida." });
            }
            else
            {
                return Unauthorized(new { message = "Usuário ou senha inválidos." });
            }
        }
    }
}
