using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BomPraCredito.Application.Services;
using BomPraCredito.Domain.Interfaces;
using BomPraCredito.Domain.Entities;

namespace BomPraCredito.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly IUserRepository _userRepository;

        public UsersController(AuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            await _userRepository.CreateUserAsync(user);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null || user.PasswordHash != password) // Lógica de verificação de senha
                return Unauthorized();

            var token = _authService.GenerateToken(user);
            return Ok(new { token });
        }
    }
}
