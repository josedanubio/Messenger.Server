using Microsoft.AspNetCore.Mvc;
using Messenger.Gerenciador.Server.Models;
using Messenger.Gerenciador.Server.Services;
using System.Threading.Tasks;

namespace Messenger.Gerenciador.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var response = await _authService.Authenticate(loginRequest);

            if (response == null)
            {
                return Unauthorized();
            }

            return Ok(response);
        }
    }
}
